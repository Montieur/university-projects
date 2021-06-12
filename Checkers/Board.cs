using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Checkers
{
    public class Board
    {
        Random rand = new Random();
        bool vsAI;
        bool ForceStrikes;
        bool BackStrikes;
        bool StrikeAvailable = false;
        bool secondPlayerTurn = false;

        List<Checker> checkers = new List<Checker>();
        List<Checker> CheckersAbleToStrike = new List<Checker>();
        Square[,] squares = new Square[8, 8];
        Grid grid;
        Checker selectedChecker;
        MainWindow window;

        public Board(MainWindow window)
        {
            this.window = window;
            this.vsAI = window.vsAI;
            this.BackStrikes = window.BackStrikes;
            this.ForceStrikes = window.ForceStrikes;
            this.grid = window.GameGrid;

            InitSquares();
            InitCheckers(window.WindowContentHeight / 10);
        }

        public void InitCheckers(double checkerSize)
        {
            char[] initialPositions = {
                ' ','X',' ','X',' ','X',' ','X',
                'X',' ','X',' ','X',' ','X',' ',
                ' ','X',' ','X',' ','X',' ','X',
                ' ',' ',' ',' ',' ',' ',' ',' ',
                ' ',' ',' ',' ',' ',' ',' ',' ',
                'O',' ','O',' ','O',' ','O',' ',
                ' ','O',' ','O',' ','O',' ','O',
                'O',' ','O',' ','O',' ','O',' '
            };

            // testing board

            //char[] initialPositions = {
            //    ' ',' ',' ',' ',' ',' ',' ',' ',
            //    ' ',' ',' ',' ',' ',' ',' ',' ',
            //    ' ',' ',' ','X',' ',' ',' ',' ',
            //    ' ',' ',' ',' ',' ',' ',' ',' ',
            //    ' ',' ',' ',' ',' ','O',' ',' ',
            //    ' ',' ',' ',' ',' ',' ',' ',' ',
            //    ' ',' ',' ',' ',' ',' ',' ',' ',
            //    ' ',' ',' ',' ',' ',' ',' ',' '
            //};

            for (int i = 0; i < initialPositions.Length; i++)
            {
                Checker checker;

                if (initialPositions[i] == 'X')
                {
                    checker = new Checker(i % 8, i / 8, checkerSize, true);
                    checker.E.MouseLeftButtonDown += (s, e) =>
                    {
                        if (secondPlayerTurn)
                        {
                            if (selectedChecker != null)
                            {
                                ShowMoves();
                                selectedChecker = null;
                            }
                            else
                            {
                                selectedChecker = checker;
                                ShowMoves();
                            }
                        }
                    };
                    squares[i % 8, i / 8].checker = checker;
                }
                else if (initialPositions[i] == 'O')
                {
                    checker = new Checker(i % 8, i / 8, checkerSize);
                    checker.E.MouseLeftButtonDown += (s, e) =>
                    {
                        if (!secondPlayerTurn)
                        {
                            if (selectedChecker != null)
                            {
                                ShowMoves();
                                selectedChecker = null;
                            }
                            else
                            {
                                selectedChecker = checker;
                                ShowMoves();
                            }
                        }
                    };
                    squares[i % 8, i / 8].checker = checker;
                }
                else continue;

                checker.SetGridPosition();
                Grid.SetZIndex(checker.E, 1);
                checkers.Add(checker);
            }

            foreach (var item in checkers)
            {
                grid.Children.Add(item.E);
            }
        }

        public void MoveChecker(Square sq)
        {
            ShowMoves();
            bool CheckerRemoved = StrikeSquare(sq);

            squares[selectedChecker.X, selectedChecker.Y].checker = null;
            selectedChecker.X = sq.X;
            selectedChecker.Y = sq.Y;
            if (!secondPlayerTurn && selectedChecker.Y == 0 && !selectedChecker.IsRankedUp) selectedChecker.RankUp();
            if (secondPlayerTurn && selectedChecker.Y == 7 && !selectedChecker.IsRankedUp) selectedChecker.RankUp();
            sq.checker = selectedChecker;
            selectedChecker.SetGridPosition();

            if (CheckerRemoved)
            {
                if (IsGameEnded())
                {
                    window.LabelWinner.Text = vsAI ? (secondPlayerTurn ? "komputer" : "gracz") : (secondPlayerTurn ? "gracz 2" : "gracz 1");
                    window.EndGameScreen.Visibility = System.Windows.Visibility.Visible;
                    if (vsAI && secondPlayerTurn) SwitchSides();
                }
                else
                {
                    SetCheckersAbleToStrike();
                    if (!CheckersAbleToStrike.Contains(selectedChecker)) SwitchSides();
                }
            }
            else SwitchSides();

            selectedChecker = null;

            if (vsAI && secondPlayerTurn)
            {
                var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
                timer.Tick += (s, e) =>
                {
                    timer.Stop();
                    MakeAutoMove();
                };
                timer.Start();
            }
        }

        private bool IsGameEnded()
        {
            foreach (var checker in checkers)
                if (checker.IsEnemy) return false;

            return true;
        }

        private void MakeAutoMove()
        {
            List<Checker> movableCheckers = new List<Checker>();

            if (ForceStrikes && CheckersAbleToStrike.Count > 0) movableCheckers = CheckersAbleToStrike;
            else foreach (var checker in checkers)
            {
                if (!checker.IsEnemy && GetAvailableSquares(checker).Count > 0)
                {
                    movableCheckers.Add(checker);
                }
            }

            selectedChecker = movableCheckers[rand.Next(0, movableCheckers.Count - 1)];
            List<Coordinate> availableMoves = GetAvailableSquares(selectedChecker);
            Coordinate destination = availableMoves[rand.Next(0, availableMoves.Count - 1)];
            ShowMoves();
            MoveChecker(squares[destination.X, destination.Y]);
        }

        public bool StrikeSquare(Square targetSquare)
        {
            int dX = targetSquare.X - selectedChecker.X;
            int dY = targetSquare.Y - selectedChecker.Y;
            Coordinate attackedSquare = new Coordinate(targetSquare.X - dX / Math.Abs(dX), targetSquare.Y - dY / Math.Abs(dY));
            if (squares[attackedSquare.X, attackedSquare.Y].checker != null && squares[attackedSquare.X, attackedSquare.Y].checker.IsEnemy)
            {
                RemoveChecker(squares[attackedSquare.X, attackedSquare.Y]);
                return true;
            }

            return false;
        }

        public void RemoveChecker(Square squareToClear)
        {
            checkers.Remove(squareToClear.checker);
            grid.Children.Remove(squareToClear.checker.E);
            squareToClear.checker = null;
        }

        public void CleanUpGrid()
        {
            foreach (var checker in checkers)
                grid.Children.Remove(checker.E);
        }

        public void InitSquares()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Square sq;

                    if (i % 2 == 0 ^ j % 2 == 0)
                    {
                        sq = new Square(j, i, false);
                        sq.area.MouseLeftButtonDown += (s, e) => { if (sq.highlighted) MoveChecker(sq); };
                    }
                    else sq = new Square(j, i, true);

                    squares[j, i] = sq;
                    grid.Children.Add(sq.selection);
                }
            }
        }

        public void SwitchSides()
        {
            secondPlayerTurn = !secondPlayerTurn;
            foreach (var checker in checkers)
                checker.IsEnemy = !checker.IsEnemy;
            SetCheckersAbleToStrike();
        }

        public bool IsValidCoordinate(Coordinate coord)
        {
            return (coord.X >= 0 && coord.X <= 7) && (coord.Y >= 0 && coord.Y <= 7);
        }

        private void SetCheckersAbleToStrike()
        {
            var CheckersAbleToStrike = new List<Checker>();

            foreach (var checker in checkers)
            {
                if (!checker.IsEnemy)
                {
                    StrikeAvailable = false;
                    GetAvailableSquares(checker);
                    if (StrikeAvailable)
                    {
                        CheckersAbleToStrike.Add(checker);
                    }
                }
            }

            this.CheckersAbleToStrike = CheckersAbleToStrike;
        }

        public List<Coordinate> GetBackStrikes(Checker examinedChecker)
        {
            List<Coordinate> availableStrikes = new List<Coordinate>();

            for (int i = 0; i < 4; i++)
            {
                if (secondPlayerTurn && (i == 1 || i == 2)) continue;
                else if (!secondPlayerTurn && (i == 0 || i == 3)) continue;
                Coordinate examinedSquare = new Coordinate(examinedChecker.X, examinedChecker.Y);
                Coordinate direction = new Coordinate(i);
                examinedSquare.AddVector(direction);

                if (IsValidCoordinate(examinedSquare)
                 && squares[examinedSquare.X, examinedSquare.Y].checker != null
                 && squares[examinedSquare.X, examinedSquare.Y].checker.IsEnemy)
                {
                    examinedSquare.AddVector(direction);
                    if (IsValidCoordinate(examinedSquare) && squares[examinedSquare.X, examinedSquare.Y].checker == null)
                        availableStrikes.Add(examinedSquare);
                }
            }

            return availableStrikes;
        }


        public List<Coordinate> GetAvailableSquares(Checker examinedChecker)
        {
            List<Coordinate> availableSquares = new List<Coordinate>();
            List<Coordinate> strikingSquares = new List<Coordinate>();

            for (int i = 0; i < 4; i++)
            {
                if (secondPlayerTurn && !examinedChecker.IsRankedUp && (i == 0 || i == 3)) continue;
                else if (!secondPlayerTurn && !examinedChecker.IsRankedUp && (i == 1 || i == 2)) continue;
                Coordinate examinedSquare = new Coordinate(examinedChecker.X, examinedChecker.Y);
                Coordinate direction = new Coordinate(i);
                bool checkForStrike = false;
                examinedSquare.X += direction.X;
                examinedSquare.Y += direction.Y;

                while (IsValidCoordinate(examinedSquare))
                {
                    if (squares[examinedSquare.X, examinedSquare.Y].checker != null)
                    {
                        if (squares[examinedSquare.X, examinedSquare.Y].checker.IsEnemy)
                        {
                            checkForStrike = true;
                            examinedSquare.AddVector(direction);
                        }
                        break;
                    }

                    availableSquares.Add(examinedSquare);
                    if (!examinedChecker.IsRankedUp) break;
                    examinedSquare.AddVector(direction);
                }

                if (checkForStrike && IsValidCoordinate(examinedSquare) && squares[examinedSquare.X, examinedSquare.Y].checker == null)
                {
                    availableSquares.Add(examinedSquare);
                    strikingSquares.Add(examinedSquare);
                }
            }

            if (BackStrikes && !examinedChecker.IsRankedUp)
                strikingSquares.AddRange(GetBackStrikes(examinedChecker));

            if (ForceStrikes && strikingSquares.Count > 0)
            {
                StrikeAvailable = true;
                return strikingSquares;
            }
            return availableSquares;
        }

        private void HighlightLegalMoves()
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(80) };
            int blinks = 4;
            timer.Tick += (s, e) =>
            {
                foreach (var checker in CheckersAbleToStrike)
                {
                    squares[checker.X, checker.Y].Highlight();
                }
                blinks--;
                if (blinks == 0) timer.Stop();
            };
            timer.Start();
        }

        public void ShowMoves()
        {
            if (ForceStrikes && CheckersAbleToStrike.Count > 0 && !CheckersAbleToStrike.Contains(selectedChecker))
            {
                HighlightLegalMoves();
                selectedChecker = null;
            }
            else
            {
                List<Coordinate> availableMoves = GetAvailableSquares(selectedChecker);

                foreach (var point in availableMoves)
                {
                    squares[point.X, point.Y].Highlight();
                }
            }
        }
    }

    public struct Coordinate
    {
        public Coordinate(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Coordinate(int direction)
        {
            switch (direction)
            {
                case 0: // north east
                    X = 1;
                    Y = -1;
                    break;
                case 1: // south east
                    X = 1;
                    Y = 1;
                    break;
                case 2: // south west
                    X = -1;
                    Y = 1;
                    break;
                case 3: // north west
                    X = -1;
                    Y = -1;
                    break;
                default:
                    X = 0;
                    Y = 0;
                    break;
            }
        }

        public void AddVector(Coordinate c)
        {
            this.X += c.X;
            this.Y += c.Y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}



from flask import Flask, jsonify, request, render_template
from flask_cors import CORS
import sudoku

app = Flask(__name__)
CORS(app)

def saveGrid(difficulty):

    boards = sudoku.createGrid(difficulty)

    startingBoard = boards[0]
    solvedBoard = boards[1]

    data = {}

    data['startingRows'] = []
    data['solvedRows'] = []

    for row in startingBoard:

        output = ""

        for col in row:
            output += str(col)

        data['startingRows'].append(str(output))

    for row in solvedBoard:

        output = ""

        for col in row:
            output += str(col)

        data['solvedRows'].append(str(output))

    return jsonify(data)
    

@app.route('/checkcontent')
def check():
    xd = sudoku.createGrid(1)
    print(xd[1])
    print(xd[0])
    print("fuckyou")
    return 'OK', 200



@app.route('/hello', methods=['GET', 'POST'])
def hello():

    # POST request
    if request.method == 'POST':
        print('Incoming..')
        print(request.get_json())  # parse as JSON
        return 'OK', 200

    # GET request
    else:
        message = {'greeting':'Hello from Flask!'}
        return jsonify(message)  # serialize and use JSON headers

@app.route('/test')
def test_page():
    # look inside `templates` and serve `index.html`
    return render_template('index.html')


@app.route('/easy')
def easy():
    return saveGrid(1)

@app.route('/normal')
def normal():
    return saveGrid(2)

@app.route('/hard')
def hard():
    return saveGrid(3)

@app.route('/expert')
def expert():
    return saveGrid(4)


@app.route("/output")
def output() :
    #saveGrid()
    return render_template("test.html", name="nigger")
    

if __name__ == "__main__" :
    app.run()
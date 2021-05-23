package familiada;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Component;
import java.awt.Container;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.FontFormatException;
import java.awt.GraphicsEnvironment;
import java.awt.Menu;
import java.awt.MenuBar;
import java.awt.MenuItem;
import java.awt.Rectangle;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ComponentEvent;
import java.awt.event.ComponentListener;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;

import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;
import javax.sound.sampled.LineEvent;
import javax.sound.sampled.LineListener;
import javax.swing.BorderFactory;
import javax.swing.Box;
import javax.swing.BoxLayout;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JRadioButton;

public class Konsola extends JFrame implements ActionListener, ComponentListener, LineListener {

	//zmienne do konsoli
	private JButton p1, p2, p3, p4, p5,
					b11, b12, b13, b14, b21, b22, b23, b24, resetUtrat,
					pdla1, pdla2,
					czolowka, nastepnaRunda, napisyKoncowe;
	private JPanel panelOdp, panelPytan, panelBledow, panelDruzyn, panelPunktow, panelDzwiekow;
	private JRadioButton d1, d2, d3;
	private JComboBox wyborPytan;
	private JFrame ramka, ekran;
	private JLabel iloscPunktow;
	private int sumaPunktow, punktyD1, punktyD2;
	private Box box1 = Box.createVerticalBox();
	private Box box2 = Box.createVerticalBox();
	private Box boxKonsoli = Box.createVerticalBox();
	private MenuBar bar;
	private Menu rozdzialka;
	private MenuItem fs, windowed, duzyEkran, malyEkran;
	private Dimension high = new Dimension(1920, 1080);
	private Dimension low = new Dimension(1280, 720);
	private Dimension currentres;
	
	String ph1, ph2, ph3, ph4, ph5;
	
	
	File dobraOdp = new File("pliczki/odpowiedz.wav");
	File przerywnik = new File("pliczki/runda.wav");
	File intro = new File("pliczki/czolowka.wav");
	File koncowka = new File("pliczki/koncowka.wav");
	File utrata = new File("pliczki/utrata.wav");
	
	Clip kliper;
	
	
	
	//zmienne do wyswietlacza
	Font foncik;
	Font duzyFoncik;
	Font megaFoncik;
	JLabel odp1, odp2, odp3, odp4, odp5,
			ilePkt1, ilePkt2, ilePkt3, ilePkt4, ilePkt5,
			duzyX2, malyX11, malyX12, malyX13, malyX21, malyX22, malyX23, duzyX1,
			licznik1, licznik2,
			poz1, poz2, poz3, poz4, poz5;
	JPanel panelWyswietlOdpowiedzi, panelKrzyzykowLewy, panelKrzyzykowPrawy, panelLicznikow;
	
	private Box boxOdpowiedzi = Box.createVerticalBox();
	private Box boxPozycji = Box.createVerticalBox();
	private Box boxPunktow = Box.createVerticalBox();
	
	
	public void ustawPH() {
		ph1 = p1.getText();
		ph2 = p2.getText();
		ph3 = p3.getText();
		ph4 = p4.getText();
		ph5 = p5.getText();
	}

	public void ustawKropki() {
		odp1.setText("....................");
		odp2.setText("....................");
		odp3.setText("....................");
		odp4.setText("....................");
		odp5.setText("....................");
		ilePkt1.setText("--");
		ilePkt2.setText("--");
		ilePkt3.setText("--");
		ilePkt4.setText("--");
		ilePkt5.setText("--");
	}
	
	public void ustawOdp() {
		odp1.setText(p1.getText());
		odp2.setText(p2.getText());
		odp3.setText(p3.getText());
		odp4.setText(p4.getText());
		odp5.setText(p5.getText());
	}
	
	public void wlaczPrzyciski() {
		p1.setEnabled(true);
		p2.setEnabled(true);
		p3.setEnabled(true);
		p4.setEnabled(true);
		p5.setEnabled(true);
	}
	
//	public static void playSound(File sound) {
//		try {
//			Clip clip = AudioSystem.getClip();
//			clip.open(AudioSystem.getAudioInputStream(sound));
//			clip.start();
//			clip.stop();
//		} catch (Exception e) {
//			e.printStackTrace();
//		}
//	}
	
	public void zagrajNutke(File pliczek) {
		try {
			kliper = AudioSystem.getClip();
			kliper.addLineListener(this);
			AudioInputStream inputStream = AudioSystem.getAudioInputStream(pliczek);
			kliper.open(inputStream);
			kliper.start();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	public Konsola() {
		
		ekran = new JFrame("FAMILIADA");
		ekran.setDefaultCloseOperation(EXIT_ON_CLOSE);
		ramka = new JFrame("Konsola");
		ramka.setDefaultCloseOperation(EXIT_ON_CLOSE);

		ekran.addComponentListener(this);
		
		
		try {
			foncik = Font.createFont(Font.TRUETYPE_FONT, new File("pliczki/familiada.ttf")).deriveFont(60f);
			duzyFoncik = Font.createFont(Font.TRUETYPE_FONT, new File("pliczki/familiada.ttf")).deriveFont(120f);
			megaFoncik = Font.createFont(Font.TRUETYPE_FONT, new File("pliczki/familiada.ttf")).deriveFont(250f);
			GraphicsEnvironment ge = GraphicsEnvironment.getLocalGraphicsEnvironment();
			ge.registerFont(Font.createFont(Font.TRUETYPE_FONT, new File("pliczki/familiada.ttf")));
			
		} catch (IOException | FontFormatException e) {
			
		}
		
		// KONSOLA KONSOLA KONSOLA KONSOLA KONSOLA KONSOLA KONSOLA KONSOLA KONSOLA KONSOLA KONSOLA KONSOLA KONSOLA 
		
		// przyciski od odslaniania odpowiedzi
		
		p1 = new JButton("1");
		p1.setActionCommand("jeden");
		p1.addActionListener(this);
		p2 = new JButton("2");
		p2.setActionCommand("dwa");
		p2.addActionListener(this);
		p3 = new JButton("3");
		p3.setActionCommand("trzy");
		p3.addActionListener(this);
		p4 = new JButton("4");
		p4.setActionCommand("cztery");
		p4.addActionListener(this);
		p5 = new JButton("5");
		p5.setActionCommand("piec");
		p5.addActionListener(this);
		
		panelOdp = new JPanel();
		panelOdp.setLayout(new BoxLayout(panelOdp, BoxLayout.Y_AXIS));
		panelOdp.setBorder(BorderFactory.createCompoundBorder(BorderFactory.createTitledBorder("Odpowiedzi"),
				BorderFactory.createEmptyBorder(5, 5, 5, 5)));
		panelOdp.add(p1);
		panelOdp.add(p2);
		panelOdp.add(p3);
		panelOdp.add(p4);
		panelOdp.add(p5);
		
		ramka.getContentPane().add(panelOdp, BorderLayout.WEST);
		
		
		// przyciski zmieniajace druzyne ktora jest przy mikrofonie
		
		d1 = new JRadioButton("Początek rundy");
		d1.setActionCommand("poczatek");
		d2 = new JRadioButton("Drużyna 1");
		d2.setActionCommand("druzynajeden");
		d3 = new JRadioButton("Drużyna 2");
		d3.setActionCommand("druzynadwa");
		
		resetUtrat = new JButton("Reset utrat");
		resetUtrat.setActionCommand("resetU");
		
		resetUtrat.addActionListener(this);
		
		d1.setSelected(true);
		
		ButtonGroup grupaDruzyn = new ButtonGroup();
		
		grupaDruzyn.add(d1);
		grupaDruzyn.add(d2);
		grupaDruzyn.add(d3);
		
		panelDruzyn = new JPanel();
//		panelDruzyn.setPreferredSize(new Dimension(50,50));
		panelDruzyn.setLayout(new BoxLayout(panelDruzyn, BoxLayout.Y_AXIS));
		panelDruzyn.setBorder(BorderFactory.createCompoundBorder(BorderFactory.createTitledBorder("Drużyna odpowiadająca"),
				BorderFactory.createEmptyBorder(5, 5, 5, 5)));
		panelDruzyn.add(d1);
		panelDruzyn.add(d2);
		panelDruzyn.add(d3);
		panelDruzyn.add(resetUtrat);
		
		ramka.getContentPane().add(panelDruzyn, BorderLayout.CENTER);
		
		// menu w ktorym bedzie mozna wybierac pytanie
		
		String[] paskiPytan = {"Imie męskie wśrod dzisiejszych gości bez litery A", "Z jakich miast przyjechali dzisiejsi goście?", "Alkohol bez litery W", "Czego nie robi idealny mężczyzna?", "Ulubiony napój Pana Młodego"};
		
		wyborPytan = new JComboBox(paskiPytan);
		wyborPytan.setSelectedItem(null);
		
		wyborPytan.addActionListener(this);
		
		
		panelPytan = new JPanel();
		panelPytan.setBorder(BorderFactory.createCompoundBorder(BorderFactory.createTitledBorder("Wybór pytania"),
				BorderFactory.createEmptyBorder(5, 5, 5, 5)));
		panelPytan.add(wyborPytan);
		
		ramka.getContentPane().add(panelPytan, BorderLayout.NORTH);
		
		// menu zaznaczania blednych odpowiedzi
		
		b11 = new JButton("X");
		b11.setActionCommand("blad11");
		b12 = new JButton("X");
		b12.setActionCommand("blad12");
		b12.setEnabled(false);
		b13 = new JButton("X");
		b13.setActionCommand("blad13");
		b13.setEnabled(false);
		b14 = new JButton("X");
		b14.setActionCommand("blad14");
//		b14.setEnabled(false);
		b21 = new JButton("X");
		b21.setActionCommand("blad21");
		b22 = new JButton("X");
		b22.setActionCommand("blad22");
		b22.setEnabled(false);
		b23 = new JButton("X");
		b23.setActionCommand("blad23");
		b23.setEnabled(false);
		b24 = new JButton("X");
		b24.setActionCommand("blad24");
//		b24.setEnabled(false);
		b14.setPreferredSize(new Dimension(50,100));
		b24.setPreferredSize(new Dimension(50,100));
		

		

		
		panelBledow = new JPanel();
		panelBledow.setBorder(BorderFactory.createCompoundBorder(BorderFactory.createTitledBorder("Błędna odpowiedź"),
				BorderFactory.createEmptyBorder(5, 5, 5, 5)));
				
		

		panelBledow.add(b24);
		panelBledow.add(b14);
		
		b11.addActionListener(this);
		b12.addActionListener(this);
		b13.addActionListener(this);
		b14.addActionListener(this);
		b21.addActionListener(this);
		b22.addActionListener(this);
		b23.addActionListener(this);
		b24.addActionListener(this);
		d1.addActionListener(this);
		d2.addActionListener(this);
		d3.addActionListener(this);
		
		ramka.getContentPane().add(panelBledow, BorderLayout.EAST);
		
		panelPunktow = new JPanel();
		pdla1 = new JButton("Punkty dla 1");
		pdla1.setActionCommand("przydzieldla1");
		pdla2 = new JButton("Punkty dla 2");
		pdla2.setActionCommand("przydzieldla2");
		pdla1.addActionListener(this);
		pdla2.addActionListener(this);
		
		
		iloscPunktow = new JLabel("Punkty w puli: "+sumaPunktow);
		
		panelPunktow.setBorder(BorderFactory.createCompoundBorder(BorderFactory.createTitledBorder("Przyznanie punktów"),
				BorderFactory.createEmptyBorder(5, 5, 5, 5)));
		
		panelPunktow.add(iloscPunktow);
		panelPunktow.add(pdla1);
		panelPunktow.add(pdla2);
		
		
		
		
		
//		ramka.getContentPane().add(panelPunktow, BorderLayout.SOUTH);	
		
		panelDzwiekow = new JPanel();
		
		czolowka = new JButton("Czołówka");
		czolowka.setActionCommand("czolowka");
		czolowka.addActionListener(this);
		nastepnaRunda = new JButton("Następna runda");
		nastepnaRunda.setActionCommand("nastepnarunda");
		nastepnaRunda.addActionListener(this);
		napisyKoncowe = new JButton("Końcówka");
		napisyKoncowe.setActionCommand("koncowka");
		napisyKoncowe.addActionListener(this);
		
		panelDzwiekow.setBorder(BorderFactory.createCompoundBorder(BorderFactory.createTitledBorder("Dźwięki"),
				BorderFactory.createEmptyBorder(5, 5, 5, 5)));
		
		panelDzwiekow.add(czolowka);
		panelDzwiekow.add(nastepnaRunda);
		panelDzwiekow.add(napisyKoncowe);
		
//		panelPunktow.add(panelDzwiekow);
		
		boxKonsoli.add(panelPunktow);
		boxKonsoli.add(panelDzwiekow);
		ramka.getContentPane().add(boxKonsoli, BorderLayout.SOUTH);
		
		bar = new MenuBar();
		rozdzialka = new Menu("Ustawienia ekranu");
		fs = new MenuItem("Pełny ekran");
		fs.setActionCommand("fullscreen");
		windowed = new MenuItem("Tryb okienkowy");
		windowed.setActionCommand("okienko");
		duzyEkran = new MenuItem("Duży ekran");
		duzyEkran.setActionCommand("highres");
		malyEkran = new MenuItem("Mały ekran");
		malyEkran.setActionCommand("lowres");
		fs.addActionListener(this);
		windowed.addActionListener(this);
		duzyEkran.addActionListener(this);
		malyEkran.addActionListener(this);
		
		rozdzialka.add(fs);
		rozdzialka.add(windowed);
		rozdzialka.addSeparator();
		rozdzialka.add(duzyEkran);
		rozdzialka.add(malyEkran);
		
		bar.add(rozdzialka);
		
		ramka.setMenuBar(bar);
		
		
		ramka.pack();
//		ramka.setVisible(true);
		
		// EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN EKRAN 
		
		ekran.setSize(new Dimension(1280,800));
		ekran.getContentPane().setBackground(Color.black);
		panelWyswietlOdpowiedzi = new JPanel();
//		panelWyswietlOdpowiedzi.setLayout(new BoxLayout(panelWyswietlOdpowiedzi, BoxLayout.Y_AXIS));
		panelWyswietlOdpowiedzi.setBackground(Color.black);
		
		
		// PANEL ODPOWIEDZI
		
		odp1 = new JLabel();
		odp1.setForeground(Color.yellow);
		odp1.setFont(foncik);
		odp2 = new JLabel();
		odp2.setForeground(Color.yellow);
		odp2.setFont(foncik);
		odp3 = new JLabel();
		odp3.setForeground(Color.yellow);
		odp3.setFont(foncik);
		odp4 = new JLabel();
		odp4.setForeground(Color.yellow);
		odp4.setFont(foncik);
		odp5 = new JLabel();
		odp5.setForeground(Color.yellow);
		odp5.setFont(foncik);
		
		odp1.setText("....................");
		odp2.setText("....................");
		odp3.setText("....................");
		odp4.setText("....................");
		odp5.setText("....................");
		
		Rectangle rect = new Rectangle(ekran.getBounds());
		
		odp1.setBorder(BorderFactory.createEmptyBorder(rect.height/5, 30, 10, 0));
		odp2.setBorder(BorderFactory.createEmptyBorder(10, 30, 10, 0));
		odp3.setBorder(BorderFactory.createEmptyBorder(10, 30, 10, 0));
		odp4.setBorder(BorderFactory.createEmptyBorder(10, 30, 10, 0));
		odp5.setBorder(BorderFactory.createEmptyBorder(10, 30, 10, 0));
		
		
		poz1 = new JLabel("1");
		poz1.setForeground(Color.yellow);
		poz1.setFont(foncik);
		poz2 = new JLabel("2");
		poz2.setForeground(Color.yellow);
		poz2.setFont(foncik);
		poz3 = new JLabel("3");
		poz3.setForeground(Color.yellow);
		poz3.setFont(foncik);
		poz4 = new JLabel("4");
		poz4.setForeground(Color.yellow);
		poz4.setFont(foncik);
		poz5 = new JLabel("5");
		poz5.setForeground(Color.yellow);
		poz5.setFont(foncik);
		
		poz1.setBorder(BorderFactory.createEmptyBorder(rect.height/5, 0, 10, 0));
		poz2.setBorder(BorderFactory.createEmptyBorder(10, 0, 10, 0));
		poz3.setBorder(BorderFactory.createEmptyBorder(10, 0, 10, 0));
		poz4.setBorder(BorderFactory.createEmptyBorder(10, 0, 10, 0));
		poz5.setBorder(BorderFactory.createEmptyBorder(10, 0, 10, 0));
		
		ilePkt1 = new JLabel("--");
		ilePkt2 = new JLabel("--");
		ilePkt3 = new JLabel("--");
		ilePkt4 = new JLabel("--");
		ilePkt5 = new JLabel("--");
		
		ilePkt1.setForeground(Color.yellow);
		ilePkt1.setFont(foncik);
		ilePkt2.setForeground(Color.yellow);
		ilePkt2.setFont(foncik);
		ilePkt3.setForeground(Color.yellow);
		ilePkt3.setFont(foncik);
		ilePkt4.setForeground(Color.yellow);
		ilePkt4.setFont(foncik);
		ilePkt5.setForeground(Color.yellow);
		ilePkt5.setFont(foncik);
		
		ilePkt1.setBorder(BorderFactory.createEmptyBorder(rect.height/5, 10, 10, 0));
		ilePkt2.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 0));
		ilePkt3.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 0));
		ilePkt4.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 0));
		ilePkt5.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 0));
		
		
		panelWyswietlOdpowiedzi.add(boxPozycji);
		panelWyswietlOdpowiedzi.add(boxOdpowiedzi);
		panelWyswietlOdpowiedzi.add(boxPunktow);
		
		boxPozycji.add(poz1);
		boxPozycji.add(poz2);
		boxPozycji.add(poz3);
		boxPozycji.add(poz4);
		boxPozycji.add(poz5);
		
		
		boxOdpowiedzi.add(odp1);
		boxOdpowiedzi.add(odp2);
		boxOdpowiedzi.add(odp3);
		boxOdpowiedzi.add(odp4);
		boxOdpowiedzi.add(odp5);
		
		boxPunktow.add(ilePkt1);
		boxPunktow.add(ilePkt2);
		boxPunktow.add(ilePkt3);
		boxPunktow.add(ilePkt4);
		boxPunktow.add(ilePkt5);
		
				
		
		ekran.getContentPane().add(panelWyswietlOdpowiedzi, BorderLayout.CENTER);
		
		//PANEL UTRATY SZANSY
		
		panelKrzyzykowLewy = new JPanel();
//		panelKrzyzykowLewy.setPreferredSize(new Dimension(200, 200));
		panelKrzyzykowLewy.add(box1);
		panelKrzyzykowLewy.setBackground(Color.black);
		panelKrzyzykowPrawy = new JPanel();
		panelKrzyzykowPrawy.add(box2);
		panelKrzyzykowPrawy.setBackground(Color.black);
		panelKrzyzykowLewy.setPreferredSize(new Dimension(230, rect.height));
		panelKrzyzykowPrawy.setPreferredSize(new Dimension(230, rect.height));
//		panelKrzyzykowPrawy.setLayout(new BoxLayout(panelKrzyzykowPrawy, BoxLayout.Y_AXIS));
		duzyX2 = new JLabel("X");
		duzyX1 = new JLabel("x");
		malyX11 = new JLabel("x");
		malyX12 = new JLabel("x");
		malyX13 = new JLabel("x");
		malyX21 = new JLabel("x");
		malyX22 = new JLabel("x");
		malyX23 = new JLabel("x");
		duzyX2.setFont(megaFoncik);
		duzyX1.setFont(megaFoncik);
		malyX11.setFont(duzyFoncik);
		malyX12.setFont(duzyFoncik);
		malyX13.setFont(duzyFoncik);
		malyX21.setFont(duzyFoncik);
		malyX22.setFont(duzyFoncik);
		malyX23.setFont(duzyFoncik);
		duzyX2.setForeground(Color.yellow);
		duzyX1.setForeground(Color.yellow);
		malyX11.setForeground(Color.yellow);
		malyX12.setForeground(Color.yellow);
		malyX13.setForeground(Color.yellow);
		malyX21.setForeground(Color.yellow);
		malyX22.setForeground(Color.yellow);
		malyX23.setForeground(Color.yellow);
		malyX11.setBorder(BorderFactory.createEmptyBorder(15, 0, 15, 0));
		malyX12.setBorder(BorderFactory.createEmptyBorder(15, 0, 15, 0));
		malyX13.setBorder(BorderFactory.createEmptyBorder(15, 0, 15, 0));
		malyX21.setBorder(BorderFactory.createEmptyBorder(15, 0, 15, 0));
		malyX22.setBorder(BorderFactory.createEmptyBorder(15, 0, 15, 0));
		malyX23.setBorder(BorderFactory.createEmptyBorder(15, 0, 15, 0));
		duzyX2.setBorder(BorderFactory.createEmptyBorder(50, 0, 10, 0));
		duzyX1.setBorder(BorderFactory.createEmptyBorder(50, 0, 10, 0));

		malyX21.setAlignmentX(Component.RIGHT_ALIGNMENT);
		malyX22.setAlignmentX(Component.RIGHT_ALIGNMENT);
		malyX23.setAlignmentX(Component.RIGHT_ALIGNMENT);
		duzyX2.setAlignmentX(Component.RIGHT_ALIGNMENT);
		
//		panelKrzyzykowLewy.setBorder(BorderFactory.createEmptyBorder(0, 0, 0, 100));
//		panelKrzyzykowPrawy.setBorder(BorderFactory.createEmptyBorder(0, 100, 0, 0));
		
		licznik1 = new JLabel(String.valueOf(punktyD1));
		licznik2 = new JLabel(String.valueOf(punktyD2));
		licznik1.setFont(duzyFoncik);
		licznik2.setFont(duzyFoncik);
		licznik1.setForeground(Color.yellow);
		licznik2.setForeground(Color.yellow);
		licznik2.setAlignmentX(Component.RIGHT_ALIGNMENT);
		
		licznik1.setBorder(BorderFactory.createEmptyBorder(0, 0, 50, 0));
		licznik2.setBorder(BorderFactory.createEmptyBorder(0, 0, 50, 0));
		
		
		
		box1.add(licznik1);
		box2.add(licznik2);
		
		ekran.getContentPane().add(panelKrzyzykowLewy, BorderLayout.WEST);
		ekran.getContentPane().add(panelKrzyzykowPrawy, BorderLayout.EAST);
		
		
		
		ekran.revalidate();
		
		ekran.setVisible(true);
		ramka.setVisible(true);
		
	}

	// LISTENER LISTENER LISTENER LISTENER LISTENER LISTENER LISTENER LISTENER LISTENER LISTENER LISTENER LISTENER LISTENER LISTENER LISTENER 

	@Override
	public void actionPerformed(ActionEvent e) {
		if(e.getActionCommand().equals("poczatek")) {
			panelBledow.removeAll();
			ramka.revalidate();
			ramka.pack();
			panelBledow.add(b24);
			panelBledow.add(b14);
			b14.setEnabled(true);
			b24.setEnabled(true);
			ramka.pack();
			ramka.revalidate();
			ramka.pack();
		}
		else if(e.getActionCommand().equals("jeden")) {
			zagrajNutke(dobraOdp);
			sumaPunktow = sumaPunktow + 35;
			odp1.setText(ph1);
			p1.setEnabled(false);
			iloscPunktow.setText("Punkty w puli: "+sumaPunktow);
			ilePkt1.setText("35");
			ramka.revalidate();
			ramka.pack();
			
		}
		else if(e.getActionCommand().equals("dwa")) {
			zagrajNutke(dobraOdp);
			sumaPunktow = sumaPunktow + 30;
			odp2.setText(ph2);
			p2.setEnabled(false);
			iloscPunktow.setText("Punkty w puli: "+sumaPunktow);
			ilePkt2.setText("30");
			ramka.revalidate();
			ramka.pack();
			
		}
		else if(e.getActionCommand().equals("trzy")) {
			zagrajNutke(dobraOdp);
			sumaPunktow = sumaPunktow + 15;
			odp3.setText(ph3);
			p3.setEnabled(false);
			iloscPunktow.setText("Punkty w puli: "+sumaPunktow);
			ilePkt3.setText("15");
			ramka.revalidate();
			ramka.pack();
			
		}
		else if(e.getActionCommand().equals("cztery")) {
			zagrajNutke(dobraOdp);
			sumaPunktow = sumaPunktow + 10;
			odp4.setText(ph4);
			p4.setEnabled(false);
			iloscPunktow.setText("Punkty w puli: "+sumaPunktow);
			ilePkt4.setText("10");
			ramka.revalidate();
			ramka.pack();
			
		}
		else if(e.getActionCommand().equals("piec")) {
			zagrajNutke(dobraOdp);
			sumaPunktow = sumaPunktow + 10;
			odp5.setText(ph5);
			p5.setEnabled(false);
			iloscPunktow.setText("Punkty w puli: "+sumaPunktow);
			ilePkt5.setText("10");
			ramka.revalidate();
			ramka.pack();
			
			
		}
		else if(e.getActionCommand().equals("blad11")) {
			zagrajNutke(utrata);
			b11.setEnabled(false);
			b12.setEnabled(true);
			box1.add(malyX11);
			box1.revalidate();
			
		}
		else if(e.getActionCommand().equals("blad12")) {
			zagrajNutke(utrata);
			b12.setEnabled(false);
			b13.setEnabled(true);
			box1.add(malyX12);
			box1.revalidate();
			
			
		}
		else if(e.getActionCommand().equals("blad13")) {
			zagrajNutke(utrata);
			b13.setEnabled(false);
			b14.setEnabled(true);
			box1.add(malyX13);
			box1.revalidate();
			
		}
		else if(e.getActionCommand().equals("blad14")) {
			zagrajNutke(utrata);
			box2.add(duzyX2);
			box2.revalidate();
			
		}
		else if(e.getActionCommand().equals("blad21")) {
			zagrajNutke(utrata);
			b21.setEnabled(false);
			b22.setEnabled(true);
			box2.add(malyX21);
			box2.revalidate();
			
		}
		else if(e.getActionCommand().equals("blad22")) {
			zagrajNutke(utrata);
			b22.setEnabled(false);
			b23.setEnabled(true);
			box2.add(malyX22);
			box2.revalidate();
			
		}
		else if(e.getActionCommand().equals("blad23")) {
			zagrajNutke(utrata);
			b23.setEnabled(false);
			b24.setEnabled(true);
			box2.add(malyX23);
			box2.revalidate();
			
		}
		else if(e.getActionCommand().equals("blad24")) {
			zagrajNutke(utrata);
			box1.add(duzyX1);
			box1.revalidate();
			
		}
		else if(e.getActionCommand().equals("czolowka")) {
			zagrajNutke(intro);
		}
		else if(e.getActionCommand().equals("nastepnarunda")) {
			zagrajNutke(przerywnik);
		}
		else if(e.getActionCommand().equals("koncowka")) {
			zagrajNutke(koncowka);
		}
		
		else if(e.getActionCommand().equals("druzynajeden")) {
			panelBledow.removeAll();
			ramka.revalidate();
			ramka.pack();
			panelBledow.add(b11);
			panelBledow.add(b12);
			panelBledow.add(b13);
			panelBledow.add(b14);
			b11.setEnabled(true);
			b14.setEnabled(false);
			ramka.pack();
			ramka.revalidate();
			ramka.pack();
		}
		else if(e.getActionCommand().equals("druzynadwa")) {
			panelBledow.removeAll();
			ramka.revalidate();
			ramka.pack();
			panelBledow.add(b24);
			panelBledow.add(b21);
			panelBledow.add(b22);
			panelBledow.add(b23);
			b21.setEnabled(true);
			b24.setEnabled(false);
			ramka.revalidate();
			ramka.pack();
		}
		else if(e.getActionCommand().equals("resetU")) {
			box1.remove(duzyX1);
			box1.remove(malyX11);
			box1.remove(malyX12);
			box1.remove(malyX13);
			box2.remove(duzyX2);
			box2.remove(malyX21);
			box2.remove(malyX22);
			box2.remove(malyX23);
			box1.revalidate();
			box2.revalidate();
		}
		else if(e.getActionCommand().equals("fullscreen")) {
			ekran.setExtendedState(ekran.MAXIMIZED_BOTH);
			ekran.setUndecorated(true);	
		}
		else if(e.getActionCommand().equals("okienko")) {
			ekran.setExtendedState(ekran.NORMAL);
			ekran.setSize(currentres);
			ekran.setUndecorated(false);
			
		}
		else if(e.getActionCommand().equals("highres")) {
			currentres = high;
			ekran.setSize(high);
		}
		else if(e.getActionCommand().equals("lowres")) {
			currentres = low;
			ekran.setSize(low);
			
		}
		else if(e.getActionCommand().equals("przydzieldla1")) {
			punktyD1 = punktyD1 + sumaPunktow;
			sumaPunktow = 0;
			iloscPunktow.setText("Punkty w puli:" + sumaPunktow);
			licznik1.setText(String.valueOf(punktyD1));
			box1.revalidate();
		}
		else if(e.getActionCommand().equals("przydzieldla2")) {
			punktyD2 = punktyD2 + sumaPunktow;
			sumaPunktow = 0;
			iloscPunktow.setText("Punkty w puli:" + sumaPunktow);
			licznik2.setText(String.valueOf(punktyD2));
			box2.revalidate();
		}
		else {
			String s = (String)wyborPytan.getSelectedItem();
			switch (s) {
			case "Imie męskie wśrod dzisiejszych gości bez litery A":
				p1.setText("Piotr");
				p2.setText("Robert");
				p3.setText("Krzysztof");
				p4.setText("Józef");
				p5.setText("Edmund");
				sumaPunktow = 0;
				iloscPunktow.setText("Punkty w puli:" + sumaPunktow);
				ustawPH();
				ustawKropki();
				wlaczPrzyciski();
				ramka.pack();
				ramka.revalidate();
				ekran.revalidate();
				break;
			case "Z jakich miast przyjechali dzisiejsi goście?":
				p1.setText("Grajewo");
				p2.setText("Kolno");
				p3.setText("Suwałki");
				p4.setText("Strumień");
				p5.setText("Poznań");
				sumaPunktow = 0;
				iloscPunktow.setText("Punkty w puli:" + sumaPunktow);
				ustawPH();
				ustawKropki();
				wlaczPrzyciski();
				ramka.pack();
				ramka.revalidate();
				ekran.revalidate();
				break;
			case "Alkohol bez litery W":
				p1.setText("Bimber");
				p2.setText("Likier");
				p3.setText("Gin");
				p4.setText("Szampan");
				p5.setText("Rum");
				sumaPunktow = 0;
				iloscPunktow.setText("Punkty w puli:" + sumaPunktow);
				ustawPH();
				ustawKropki();
				wlaczPrzyciski();
				ramka.pack();
				ramka.revalidate();
				ekran.revalidate();
				break;
			case "Czego nie robi idealny mężczyzna?":
				p1.setText("Nie istnieje");
				p2.setText("Nie pije");
				p3.setText("Nie pali");
				p4.setText("Nie zdradza");
				p5.setText("Nie sprzecza się");
				sumaPunktow = 0;
				iloscPunktow.setText("Punkty w puli:" + sumaPunktow);
				ustawPH();
				ustawKropki();
				wlaczPrzyciski();
				ramka.pack();
				ramka.revalidate();
				ekran.revalidate();
				break;
			case "Ulubiony napój Pana Młodego":
				p1.setText("Whisky z colą");
				p2.setText("Cola");
				p3.setText("Piwo");
				p4.setText("Red Bull");
				p5.setText("Kawa z mlekiem");
				sumaPunktow = 0;
				iloscPunktow.setText("Punkty w puli:" + sumaPunktow);
				ustawPH();
				ustawKropki();
				wlaczPrzyciski();
				ramka.pack();
				ramka.revalidate();
				ekran.revalidate();
				break;
			}
			
		}
		
	}

	@Override
	public void componentHidden(ComponentEvent arg0) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void componentMoved(ComponentEvent arg0) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void componentResized(ComponentEvent e) {
		
//		odp1.setBorder(BorderFactory.createEmptyBorder(ekran.getBounds().height/5, ekran.getBounds().width/8, 10, 0));
//		odp2.setBorder(BorderFactory.createEmptyBorder(10, ekran.getBounds().width/8, 10, 0));
//		odp3.setBorder(BorderFactory.createEmptyBorder(10, ekran.getBounds().width/8, 10, 0));
//		odp4.setBorder(BorderFactory.createEmptyBorder(10, ekran.getBounds().width/8, 10, 0));
//		odp5.setBorder(BorderFactory.createEmptyBorder(10, ekran.getBounds().width/8, 10, 0));

		
	}

	@Override
	public void componentShown(ComponentEvent arg0) {
		// TODO Auto-generated method stub
		
	}


	@Override
	public void update(LineEvent le) {
		
		if(le.getType() == LineEvent.Type.STOP) {
			kliper.close();
		}
		
	}
	
	public static void main(String [] args) {
		new Konsola();
	}
	
}

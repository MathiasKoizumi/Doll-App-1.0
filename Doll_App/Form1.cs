using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WMPLib;

namespace Doll_App
{
	public class Form1 : Form
	{
		private Random random;

		private bool soundOn;

		private bool soundOn2;

		private bool soundOn3;

		private bool soundOn4;

		private bool waveOn;

		private int wavePercent;

		private int waveVol;

		private int waveVol2;

		private int waveVol3;

		private int waveVol4;

		private bool waveUp;

		private bool waveUp2;

		private bool waveUp3;

		private bool waveUp4;

		private string path;

		private string file;

		private string label;

		private WindowsMediaPlayer wplayer;

		private WindowsMediaPlayer wplayer2;

		private WindowsMediaPlayer wplayer3;

		private WindowsMediaPlayer wplayer4;

		private IContainer components = null;

		private TrackBar trackBarVol;

		private Label labelVolume;

		private Timer timerPic;

		private Timer timerMoans;

		private Button button1;

		private Label labelFile;

		private Button button4;

		private Button button3;

		private Button button2;

		private PictureBox pictureBox1;

		private Timer timerAcapela;

		private Timer timerMusic;

		private Timer timerPond5;

		private Label labelSignature;

		private Timer timerVariance;

		private Timer timerRandomVol;

		private Button button5;

		private PictureBox pictureBox2;

		public Form1()
		{
			InitializeComponent();
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			random = new Random();
			wplayer = (WindowsMediaPlayer)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")));
			wplayer2 = (WindowsMediaPlayer)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")));
			wplayer3 = (WindowsMediaPlayer)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")));
			wplayer4 = (WindowsMediaPlayer)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")));
			waveVol = 100;
			waveVol2 = 100;
			waveVol3 = 100;
			waveVol4 = 100;
			waveUp = true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
		}

		private void timerPic_Tick(object sender, EventArgs e)
		{
			string str = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            string str2 = "1.gif";
			switch (random.Next(59))
			{
			case 0:
				str2 = "1.gif";
				break;
			case 1:
				str2 = "1.jpg";
				break;
			case 2:
				str2 = "10.gif";
				break;
			case 3:
				str2 = "10.jpg";
				break;
			case 4:
				str2 = "11.gif";
				break;
			case 5:
				str2 = "12.gif";
				break;
			case 6:
				str2 = "12.jpg";
				break;
			case 7:
				str2 = "13.gif";
				break;
			case 8:
				str2 = "14.gif";
				break;
			case 9:
				str2 = "14.jpg";
				break;
			case 10:
				str2 = "15.jpg";
				break;
			case 11:
				str2 = "16.jpg";
				break;
			case 12:
				str2 = "17.png";
				break;
			case 13:
				str2 = "18.jpg";
				break;
			case 14:
				str2 = "19.jpg";
				break;
			case 15:
				str2 = "2.gif";
				break;
			case 16:
				str2 = "2.jpg";
				break;
			case 17:
				str2 = "20.jpg";
				break;
			case 18:
				str2 = "21.jpg";
				break;
			case 19:
				str2 = "22.jpg";
				break;
			case 20:
				str2 = "23.jpg";
				break;
			case 21:
				str2 = "23.jpg";
				break;
			case 22:
				str2 = "24.jpg";
				break;
			case 23:
				str2 = "25.jpg";
				break;
			case 24:
				str2 = "26.jpg";
				break;
			case 25:
				str2 = "27.jpg";
				break;
			case 26:
				str2 = "28.jpg";
				break;
			case 27:
				str2 = "29.jpg";
				break;
			case 28:
				str2 = "3.gif";
				break;
			case 29:
				str2 = "3.jpg";
				break;
			case 30:
				str2 = "30.jpg";
				break;
			case 31:
				str2 = "31.jpg";
				break;
			case 32:
				str2 = "32.jpg";
				break;
			case 33:
				str2 = "33.jpg";
				break;
			case 34:
				str2 = "34.jpg";
				break;
			case 35:
				str2 = "35.jpg";
				break;
			case 37:
				str2 = "36.jpg";
				break;
			case 38:
				str2 = "37.jpg";
				break;
			case 39:
				str2 = "38.jpg";
				break;
			case 40:
				str2 = "39.jpg";
				break;
			case 41:
				str2 = "4.gif";
				break;
			case 42:
				str2 = "4.jpg";
				break;
			case 43:
				str2 = "40.jpg";
				break;
			case 44:
				str2 = "41.jpg";
				break;
			case 45:
				str2 = "42.jpg";
				break;
			case 46:
				str2 = "42.jpg";
				break;
			case 47:
				str2 = "43.jpg";
				break;
			case 48:
				str2 = "44.jpg";
				break;
			case 49:
				str2 = "5.gif";
				break;
			case 50:
				str2 = "5.jpg";
				break;
			case 51:
				str2 = "6.gif";
				break;
			case 52:
				str2 = "6.jpg";
				break;
			case 53:
				str2 = "7.gif";
				break;
			case 54:
				str2 = "7.jpg";
				break;
			case 55:
				str2 = "8.gif";
				break;
			case 56:
				str2 = "8.jpg";
				break;
			case 57:
				str2 = "9.gif";
				break;
			case 58:
				str2 = "9.jpg";
				break;
			}


            var names = Assembly.GetExecutingAssembly();
           
            pictureBox1.Image = Image.FromFile("Doll_App\\Images." + str2);
			timerPic.Interval = random.Next(3000, 8000);
		}

		private void TimerMoans_Tick(object sender, EventArgs e)
		{
			LoopMoans();
		}

		private void timerAcapela_Tick(object sender, EventArgs e)
		{
			PlayDoll();
		}

		private void timerMusic_Tick(object sender, EventArgs e)
		{
			PlayMusic();
		}

		private void timerPond5_Tick(object sender, EventArgs e)
		{
			PlayPond5();
		}

		private void timerRefresh_Tick(object sender, EventArgs e)
		{
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (!soundOn)
			{
				soundOn = true;
				timerMoans.Enabled = true;
				button1.Text = "Turn of...";
				button1.BackColor = Color.IndianRed;
			}
			else
			{
				timerMoans.Enabled = false;
				wplayer.controls.stop();
				soundOn = false;
				button1.Text = "Start moaning";
				button1.BackColor = Color.LightGreen;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!soundOn2)
			{
				soundOn2 = true;
				timerAcapela.Enabled = true;
				button2.Text = "Shut down...";
				button2.BackColor = Color.IndianRed;
			}
			else
			{
				timerAcapela.Enabled = false;
				wplayer2.controls.stop();
				soundOn2 = false;
				button2.Text = "Talk my doll";
				button2.BackColor = Color.LightGreen;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (!soundOn3)
			{
				soundOn3 = true;
				timerPond5.Enabled = true;
				button3.Text = "Stop Panting...!";
				button3.BackColor = Color.IndianRed;
			}
			else
			{
				timerPond5.Enabled = false;
				wplayer3.controls.stop();
				soundOn3 = false;
				button3.Text = "More sex!";
				button3.BackColor = Color.LightGreen;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (!soundOn4)
			{
				soundOn4 = true;
				timerMusic.Enabled = true;
				button4.Text = "Stop music...";
				button4.BackColor = Color.IndianRed;
			}
			else
			{
				timerMusic.Enabled = false;
				wplayer4.controls.stop();
				soundOn4 = false;
				button4.Text = "Turn on music..:)";
				button4.BackColor = Color.LightGreen;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			waveVol = random.Next(100);
			waveVol2 = random.Next(100);
			waveVol3 = random.Next(100);
			waveVol4 = random.Next(100);
			waveOn = !waveOn;
			if (waveOn)
			{
				button5.BackColor = Color.IndianRed;
			}
			else
			{
				button5.BackColor = Color.LightGreen;
			}
			wavePercent = trackBarVol.Value;
			timerVariance.Enabled = true;
		}

		private void LoopMoans()
		{
			if (soundOn && (wplayer.playState == WMPPlayState.wmppsUndefined || wplayer.playState == WMPPlayState.wmppsStopped || wplayer.playState != WMPPlayState.wmppsTransitioning))
			{
				path = "Doll_App\\Sounds.Moans.";
				file = "";
				if (wplayer.playState != WMPPlayState.wmppsPlaying)
				{
					switch (random.Next(13))
					{
					case 0:
						file = "0.wav";
						label = "Yes...";
						break;
					case 1:
						file = "1.wav";
						label = "Dooo me...please";
						break;
					case 2:
						file = "2.wav";
						label = "No...stop!!!";
						break;
					case 3:
						file = "3.wav";
						label = "Continue....master...<3";
						break;
					case 4:
						file = "4.wav";
						label = "Say you love me <3";
						break;
					case 5:
						file = "5.wav";
						label = "Fuck me hard!!!";
						break;
					case 6:
						file = "6.wav";
						label = "Dont leave me....ever...";
						break;
					case 7:
						file = "7.wav";
						label = "Fill my pussy with CUM....";
						break;
					case 8:
						file = "8.wav";
						label = "Try harder...harder...more";
						break;
					case 9:
						file = "9.wav";
						label = "Go nuts....i like it....<3";
						break;
					case 10:
						file = "10.wav";
						label = "Scream...pant...say something...i want you!!!";
						break;
					case 11:
						file = "11.wav";
						label = "Yes, yes...yes...more!";
						break;
					case 12:
						file = "12.wav";
						label = "Do that again mister...save me :)";
						break;
					}
					wplayer.URL = path + file;
                     
					wplayer.settings.volume = waveVol;
					wplayer.controls.play();
					labelFile.Text = label;
				}
			}
		}

		private void PlayDoll()
		{
			if (soundOn2 && (wplayer2.playState == WMPPlayState.wmppsUndefined || wplayer2.playState == WMPPlayState.wmppsStopped || wplayer2.playState != WMPPlayState.wmppsTransitioning))
			{
				path = "Doll_App\\Sounds.Acapela.";
				file = "";
				if (wplayer2.playState != WMPPlayState.wmppsPlaying)
				{
					switch (random.Next(13))
					{
					case 0:
						label = "Talk to me!";
						break;
					case 1:
						label = "Youre funny :)";
						break;
					case 2:
						label = "Give me a smile <3";
						break;
					case 3:
						label = "Good golly!!!";
						break;
					case 4:
						label = "My name is....?";
						break;
					case 5:
						label = "Dont worry...were so lucky...dont you think? :)";
						break;
					case 6:
						label = "Im sad....will you comfort me (╥\ufe4f╥)";
						break;
					case 7:
						label = "Yes....im good!";
						break;
					case 8:
						label = "Dont tickle me PLEASE ( \u0361° \u035c °)";
						break;
					case 9:
						label = "I ate a cake.....want some??? ;-) ";
						break;
					case 10:
						label = "Can you hold my hand...meanwhile?";
						break;
					case 11:
						label = "I really LOVE the way you talk to me!!!";
						break;
					case 12:
						label = "Take me to your sister!! NOW!!  •`_\u00b4•";
						break;
					}
					switch (random.Next(13))
					{
					case 0:
						file = "1.mp3";
						break;
					case 1:
						file = "10.mp3";
						break;
					case 2:
						file = "11.mp3";
						break;
					case 3:
						file = "12.mp3";
						break;
					case 4:
						file = "13.mp3";
						break;
					case 5:
						file = "14.mp3";
						break;
					case 6:
						file = "15.mp3";
						break;
					case 7:
						file = "16.mp3";
						break;
					case 8:
						file = "2.mp3";
						break;
					case 9:
						file = "3.mp3";
						break;
					case 10:
						file = "4.mp3";
						break;
					case 11:
						file = "5.mp3";
						break;
					case 12:
						file = "6.mp3";
						break;
					}
					wplayer2.URL = path + file;
					wplayer2.controls.play();
					labelFile.Text = label;
				}
			}
		}

		private void PlayPond5()
		{
			if (soundOn3 && (wplayer3.playState == WMPPlayState.wmppsUndefined || wplayer3.playState == WMPPlayState.wmppsStopped || wplayer3.playState != WMPPlayState.wmppsTransitioning))
			{
				path = "Doll_App\\Sounds.Pond5.";
				file = "";
				if (wplayer3.playState != WMPPlayState.wmppsPlaying)
				{
					switch (random.Next(13))
					{
					case 0:
						label = "You are soo HOT... ;)";
						break;
					case 1:
						label = "Forgive me, i LOVE this :)";
						break;
					case 2:
						label = "Harder....NOW <3";
						break;
					case 3:
						label = "I like this game...";
						break;
					case 4:
						label = "Put this in the Dolls, please :)";
						break;
					case 5:
						label = "This took me 3 days to make...";
						break;
					case 6:
						label = "Make european Dolls....agree??? :)";
						break;
					case 7:
						label = "You can call me - +45 27 24 19 32";
						break;
					case 8:
						label = "This is my gift to the world :)";
						break;
					case 9:
						label = "Terraform Earth...";
						break;
					case 10:
						label = "Say you love this product!! <3";
						break;
					case 11:
						label = "Well done...:)";
						break;
					case 12:
						label = "<3 <3 <3 \u00af\\_(ツ)_/\u00af <3 <3 <3";
						break;
					}
					switch (random.Next(22))
					{
					case 0:
						file = "Voice1.wav";
						break;
					case 1:
						file = "Voice10.wav";
						break;
					case 2:
						file = "Voice11.wav";
						break;
					case 3:
						file = "Voice12.wav";
						break;
					case 4:
						file = "Voice13.wav";
						break;
					case 5:
						file = "Voice14.wav";
						break;
					case 6:
						file = "Voice15.wav";
						break;
					case 7:
						file = "Voice16.wav";
						break;
					case 8:
						file = "Voice17.wav";
						break;
					case 9:
						file = "Voice18.wav";
						break;
					case 10:
						file = "Voice19.wav";
						break;
					case 11:
						file = "Voice2.wav";
						break;
					case 12:
						file = "Voice20.wav";
						break;
					case 13:
						file = "Voice21.wav";
						break;
					case 14:
						file = "Voice3.wav";
						break;
					case 15:
						file = "Voice4.wav";
						break;
					case 16:
						file = "Voice5.wav";
						break;
					case 17:
						file = "Voice6.wav";
						break;
					case 18:
						file = "Voice7.wav";
						break;
					case 19:
						file = "Voice8.wav";
						break;
					case 20:
						file = "Voice9.wav";
						break;
					case 21:
						file = "Voice22.wav";
						break;
					case 22:
						file = "Voice23.wav";
						break;
					}
					wplayer3.URL = path + file;
					wplayer3.controls.play();
					labelFile.Text = label;
				}
			}
		}

		private void PlayMusic()
		{
			if (soundOn4 && (wplayer4.playState == WMPPlayState.wmppsUndefined || wplayer4.playState == WMPPlayState.wmppsStopped || wplayer4.playState != WMPPlayState.wmppsTransitioning))
			{
				path = "Doll_App\\Sounds.Music.";
				file = "";
				if (wplayer4.playState != WMPPlayState.wmppsPlaying)
				{
					switch (random.Next(13))
					{
					case 0:
						label = "This sounds GREAT!!!";
						break;
					case 1:
						label = "mathiaskoizumi@hotmail.com";
						break;
					case 2:
						label = "Soundcloud - Mathias Koizumi";
						break;
					case 3:
						label = "\u00af\\\\_(ツ)_//\u00af";
						break;
					case 4:
						label = "My name is....?";
						break;
					case 5:
						label = "Mathias Ken (Tanaka) Makoto Koizumi";
						break;
					case 6:
						label = "Listen very carefully :)";
						break;
					case 7:
						label = "God, its good ;)";
						break;
					case 8:
						label = "Fine, cancel subscription....Sigh!!";
						break;
					case 9:
						label = "Find my tone...";
						break;
					case 10:
						label = "Eat my dust, lol :)";
						break;
					case 11:
						label = "Macs are finegrade....";
						break;
					case 12:
						label = "•`_\u00b4•";
						break;
					}
					switch (random.Next(12))
					{
					case 0:
						file = "bedaroi.mp3";
						break;
					case 1:
						file = "Blue sky.mp3";
						break;
					case 2:
						file = "DarloksAgain.mp3";
						break;
					case 3:
						file = "Epiphany.mp3";
						break;
					case 4:
						file = "Fire from above.mp3";
						break;
					case 5:
						file = "Fizzle.mp3";
						break;
					case 6:
						file = "Mushroom.mp3";
						break;
					case 7:
						file = "Sector 1B.mp3";
						break;
					case 8:
						file = "Segoia!!!!.mp3";
						break;
					case 9:
						file = "Speak what is on your mind.mp3";
						break;
					case 10:
						file = "wartimesoon.mp3";
						break;
					case 11:
						file = "mors nummer.mp3";
						break;
					}
					wplayer4.URL = path + file;
					wplayer4.settings.volume = waveVol;
					wplayer4.controls.play();
					labelFile.Text = label;
				}
			}
		}

		private void timerVariance_Tick(object sender, EventArgs e)
		{
			if (waveOn)
			{
				if (waveUp)
				{
					waveVol++;
				}
				if (!waveUp)
				{
					waveVol--;
				}
				if (waveUp2)
				{
					waveVol2++;
				}
				if (!waveUp2)
				{
					waveVol2--;
				}
				if (waveUp3)
				{
					waveVol3++;
				}
				if (!waveUp3)
				{
					waveVol3--;
				}
				if (waveUp4)
				{
					waveVol4++;
				}
				if (!waveUp4)
				{
					waveVol4--;
				}
				WaveVol();
				wplayer.settings.volume = waveVol;
				wplayer2.settings.volume = waveVol2;
				wplayer3.settings.volume = waveVol3;
				wplayer4.settings.volume = waveVol4;
			}
		}

		private void WaveVol()
		{
			if (waveUp && waveVol >= wavePercent)
			{
				waveUp = false;
			}
			if (!waveUp && waveVol <= 1)
			{
				waveUp = true;
			}
			if (waveUp2 && waveVol2 >= wavePercent)
			{
				waveUp2 = false;
			}
			if (!waveUp2 && waveVol2 <= 1)
			{
				waveUp2 = true;
			}
			if (waveUp3 && waveVol3 >= wavePercent)
			{
				waveUp3 = false;
			}
			if (!waveUp3 && waveVol3 <= 1)
			{
				waveUp3 = true;
			}
			if (waveUp4 && waveVol4 >= wavePercent)
			{
				waveUp4 = false;
			}
			if (!waveUp4 && waveVol4 <= 1)
			{
				waveUp4 = true;
			}
		}

		private void trackBarVol_ValueChanged(object sender, EventArgs e)
		{
			wavePercent = trackBarVol.Value;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.trackBarVol = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.timerPic = new System.Windows.Forms.Timer(this.components);
            this.timerMoans = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerAcapela = new System.Windows.Forms.Timer(this.components);
            this.timerMusic = new System.Windows.Forms.Timer(this.components);
            this.timerPond5 = new System.Windows.Forms.Timer(this.components);
            this.labelSignature = new System.Windows.Forms.Label();
            this.timerVariance = new System.Windows.Forms.Timer(this.components);
            this.timerRandomVol = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarVol
            // 
            this.trackBarVol.Location = new System.Drawing.Point(1320, 104);
            this.trackBarVol.Maximum = 100;
            this.trackBarVol.Name = "trackBarVol";
            this.trackBarVol.Size = new System.Drawing.Size(388, 69);
            this.trackBarVol.SmallChange = 10;
            this.trackBarVol.TabIndex = 4;
            this.trackBarVol.TickFrequency = 10;
            this.trackBarVol.ValueChanged += new System.EventHandler(this.trackBarVol_ValueChanged);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.Location = new System.Drawing.Point(1437, 60);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(198, 29);
            this.labelVolume.TabIndex = 5;
            this.labelVolume.Text = "Voice variance %";
            // 
            // timerPic
            // 
            this.timerPic.Enabled = true;
            this.timerPic.Tick += new System.EventHandler(this.timerPic_Tick);
            // 
            // timerMoans
            // 
            this.timerMoans.Tick += new System.EventHandler(this.TimerMoans_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(90, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Moaning";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(618, 34);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(262, 32);
            this.labelFile.TabIndex = 13;
            this.labelFile.Text = "Sex doll - The app";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGreen;
            this.button4.Location = new System.Drawing.Point(961, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "Music by me <3";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Location = new System.Drawing.Point(673, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sexy talk";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Location = new System.Drawing.Point(383, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Talking doll...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(90, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1537, 705);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // timerAcapela
            // 
            this.timerAcapela.Tick += new System.EventHandler(this.timerAcapela_Tick);
            // 
            // timerMusic
            // 
            this.timerMusic.Tick += new System.EventHandler(this.timerMusic_Tick);
            // 
            // timerPond5
            // 
            this.timerPond5.Tick += new System.EventHandler(this.timerPond5_Tick);
            // 
            // labelSignature
            // 
            this.labelSignature.AutoSize = true;
            this.labelSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignature.Location = new System.Drawing.Point(1780, 968);
            this.labelSignature.Name = "labelSignature";
            this.labelSignature.Size = new System.Drawing.Size(69, 25);
            this.labelSignature.TabIndex = 14;
            this.labelSignature.Text = "MK18";
            // 
            // timerVariance
            // 
            this.timerVariance.Tick += new System.EventHandler(this.timerVariance_Tick);
            // 
            // timerRandomVol
            // 
            this.timerRandomVol.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGreen;
            this.button5.Location = new System.Drawing.Point(1424, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 60);
            this.button5.TabIndex = 15;
            this.button5.Text = "Wave volumetrics";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1644, 825);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1894, 1020);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labelSignature);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.trackBarVol);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Sex doll - The app";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

       
    }
}

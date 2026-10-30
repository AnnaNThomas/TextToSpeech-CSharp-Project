using System;
using System.Windows.Forms;
using System.Speech.Synthesis;



namespace project8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer synthVoice;




        private void Form1_Load(object sender, EventArgs e)
        {
            synthVoice = new SpeechSynthesizer();
            foreach (InstalledVoice voice in synthVoice.GetInstalledVoices())
            {
                VoiceInfo infoVoice = voice.VoiceInfo;
                comboBox1.Items.Add(infoVoice.Name);
                txtSpechText.Text += infoVoice.Name + "\r\n";
                txtSpechText.Text += infoVoice.Age + "\r\n";
                txtSpechText.Text += infoVoice.Culture + "\r\n";
                txtSpechText.Text += infoVoice.Gender + "\r\n";
                txtSpechText.Text += infoVoice.Description + "\r\n";
                txtSpechText.Text += "==============" + "\r\n";


            }
            synthVoice.Dispose();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {



        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            string voice = comboBox1.Text;
            string theText = txtSpechText.Text;
            if (voice == "Select Voice")
            {

                MessageBox.Show("Select a Voice");
                return;

            }
            if (theText == "")
            {

                MessageBox.Show("Type some text");
                return;

            }
            synthVoice = new SpeechSynthesizer();
            synthVoice.SetOutputToDefaultAudioDevice();
            synthVoice.SelectVoice(voice);
            synthVoice.Rate = trackBar1.Value;
            synthVoice.Volume = trackBar2.Value;
            synthVoice.SpeakAsync(theText);
















        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            synthVoice.Dispose();


        }
    }
}

using Lynaar_GUI.Classes;
using Lynaar_GUI.Login_Parts.UC_;
using Lynaar_GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using NAudio;
using NAudio.Wave;
using System.Diagnostics;
using Lynaar_GUI.Classes.Miscellaneous;
using System.Runtime.InteropServices;
using System.Threading;

namespace Lynaar_GUI
{
    public partial class LoginForm : Form
    {
        #region Attributs

        //! Initialisation des variables pour la musique
        private WaveOutEvent outputDevice;          //! Correspond au périphérique de sortie audio (le programme)
        private RawSourceWaveStream audioFile;      //! Correspond au fichier audio à lire


        private Bitmap soundOn;
        private Bitmap soundOff;

        //! Curseurs
        private Cursor originalCursor;
        private Cursor hoverCursor;

        private Thread mainMusic_THREAD;


        List<Dictionary<string, object>> allPlayers;

        #endregion

        public LoginForm(List<Dictionary<string, object>> players)
        {
            InitializeComponent();
            allPlayers = players;
        }

        private void LoggingForm_Load(object sender, EventArgs e)
        {
            //! Initialisation de la musique
            this.mainMusic_THREAD = new Thread(new ThreadStart(PlayMusic));
            this.mainMusic_THREAD.Start();

            //! Ajout de l'UC (UserControl) UC_LoginMainMenu dans le panel 'pnl_LoginMain' au chargement du Formulaire
            FunctionsLibs.add_UControls(new UC_LoginMainMenu(this, allPlayers), pnl_LoginMain);

            this.soundOff = Resources.Volume_Off;
            this.soundOn = Resources.Volume_On;

            //! Initialisation des curseurs
            this.hoverCursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalHelp.ani"));
            this.originalCursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalSelect.ani"));


            resetCursor();
            

        }


        #region Music Methods

        //! Fonction permettant de jouer la musique
        public void PlayMusic()
        {
            //!Si le périphérique de sortie audio n'est pas initialisé, on le fait et on joue la musique
            if (outputDevice == null)
            {
                this.audioFile = new RawSourceWaveStream(Properties.Resources.SOUND_mainMenu, new WaveFormat());
                LoopStream loop = new LoopStream(this.audioFile);       //! Fonction permettant de lire en boucle le fichier audio
                outputDevice = new WaveOutEvent();
                outputDevice.Init(loop);
                outputDevice.Play();
            }
            else
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }


        }

        //! Fonction permettant de mettre le son en pause ou de le relancer (sans supprimer les autres sons en cours)
        private void OnOffSound(object sender, EventArgs e)
        {
            //! Si le son est en cours de lecture, on le met en pause et on change l'image du bouton
            if ((this.outputDevice.PlaybackState == PlaybackState.Playing))
            {
                this.outputDevice.Pause();

                this.picBox_VolumeOnOff.BackgroundImage = this.soundOff;
            }
            //! Sinon, on le relance et on change l'image du bouton
            else
            {
                this.outputDevice.Play();
                this.picBox_VolumeOnOff.BackgroundImage = this.soundOn;
            }

        }


        #endregion


        //! Change le curseur quand on passe sur le bouton du son
        private void picBox_VolumeOnOff_MouseEnter(object sender, EventArgs e)
        {
            changeCursor();
        }

        //! Remet le curseur par défaut quand on quitte le bouton du son
        private void picBox_VolumeOnOff_MouseLeave(object sender, EventArgs e)
        {
            resetCursor();
        }


        #region Cursor
        private void changeCursor()
        {
            this.Cursor = this.hoverCursor;
        }

        private void resetCursor()
        {
            this.Cursor = this.originalCursor;
        }

        #endregion
    }


}

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

namespace Lynaar_GUI
{
    public partial class LoginForm : Form
    {
        #region Attributs

        //! Initialisation des variables pour la musique
        private WaveOutEvent outputDevice;          //! Correspond au périphérique de sortie audio (le programme)
        private RawSourceWaveStream audioFile;      //! Correspond au fichier audio à lire

        #endregion

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoggingForm_Load(object sender, EventArgs e)
        {
            //! Ajout de l'UC (UserControl) UC_LoginMainMenu dans le panel 'pnl_LoginMain' au chargement du Formulaire
            //? 'this' permet de passer le formulaire en paramètre pour pouvoir le fermer depuis l'UC
            FunctionsLibs.add_UControls(new UC_LoginMainMenu(this), pnl_LoginMain);

            resetCursor();
            //! Initialisation de la musique
            playMusic();

        }


        #region Music Methods

        //! Fonction permettant de jouer la musique
        public void playMusic()
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

                this.picBox_VolumeOnOff.BackgroundImage = Resources.Volume_Off;
            }
            //! Sinon, on le relance et on change l'image du bouton
            else
            {
                this.outputDevice.Play();
                this.picBox_VolumeOnOff.BackgroundImage = Resources.Volume_On;
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


        #region Cursor Methods

        //! Fonctions permettant de changer le curseur
        private void changeCursor()
        {
            this.Cursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalHelp.ani"));
        }

        private void resetCursor()
        {
            this.Cursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalSelect.ani"));
        }

        #endregion
    }


}

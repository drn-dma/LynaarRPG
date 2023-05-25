using Lynaar_GUI.Classes;
using Lynaar_GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI.Game_Parts.UC_
{
    public partial class UC_GameFight : UserControl
    {
        private Lynaar_GUI.GameForm mainForm;
        private Monstre monstreActuel;
        private List<Dictionary<string,object>> lesMonstres;



        #region Fonts
        private Font font10;
        private Font font12;
        private Font font15;
        private Font font20;
        #endregion

        public UC_GameFight(Lynaar_GUI.GameForm parentForm)
        {
            InitializeComponent(); 
            
            this.mainForm = parentForm;

            this.font10 = new Font(FunctionsLibs.Font_Alkhemikal, 10);
            this.font12 = new Font(FunctionsLibs.Font_Alkhemikal, 12);
            this.font15 = new Font(FunctionsLibs.Font_Alkhemikal, 15);
            this.font20 = new Font(FunctionsLibs.Font_Alkhemikal, 20);

            #region Load Enemy Informations
            this.lesMonstres = SQLConnect.viewMonsters();
            var rand = new Random();
            int index = rand.Next(0, this.lesMonstres.Count);

            int monstreLevl = rand.Next(1,3);

            this.monstreActuel = new Monstre(this.lesMonstres[index], this.mainForm.CurrentPlayer.Level + monstreLevl);
            #endregion

           
            switch (this.mainForm.CurrentPlayer.Classe)
            {
                case "warrior":
                    this.picBox_Spell1.Image = (Image)Resources.W_SPELL_Boost_Attack;
                    break;
                case "sorcerer":
                    this.picBox_Spell1.Image = (Image)Resources.S_SPELL_Ice_Tempest;
                    break;
                case "hunter":
                    this.picBox_Spell1.Image = (Image)Resources.H_SPELL_HeadShot;
                    break;
                case "rogue":
                    this.picBox_Spell1.Image = (Image)Resources.R_SPELL_Attack_From_Back;
                    break;
            }

            this.picBox_AttackBtn.Image = (Image)Resources.SPELL_Auto;

        }

        private void UC_GameFight_Load(object sender, EventArgs e)
        {
            if(this.monstreActuel.Id == 25)
            {
                this.picBox_AvatarEnemy.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"_{this.monstreActuel.Id}_{this.mainForm.CurrentPlayer.Classe}");
                this.monstreActuel.Hp = this.mainForm.CurrentPlayer.Hp;
                this.monstreActuel.DmgMin = this.mainForm.CurrentPlayer.Damage;
                this.monstreActuel.DmgMax = this.mainForm.CurrentPlayer.Damage;
            }
            else
            {
                this.picBox_AvatarEnemy.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"_{this.monstreActuel.Id}");
            }
            this.lbl_EnemyName.Text = this.monstreActuel.Name;
            this.lbl_EnemyName.ForeColor = Color.Red;
            this.lblEnemyLevel.Text = this.monstreActuel.Level.ToString();

            this.lbl_EnemyHealth.Text = this.monstreActuel.Hp.ToString();
            this.lbl_EnemyHealth.ForeColor = Color.Red;


            this.lbl_EnemyDamage.Text = this.monstreActuel.DmgMin.ToString() + " - " + this.monstreActuel.DmgMax.ToString();

            appendToConsole($"{monstreActuel.Name}", Color.Red);
            appendToConsole($" has appeared with ", Color.White);
            appendToConsole($"{monstreActuel.Hp}", Color.Red);
            appendToConsole($" HP !", Color.White);
            
        }




        private void attack(object sender, EventArgs e)
        {
            PictureBox attackPic = (PictureBox)sender;
            switch (attackPic.Name)
            {
                case "picBox_AttackBtn":
                    lunchBasicAttack();
                    break;
                /*case "picBox_Spell1":
                    this.mainForm.CurrentPlayer.useSpell1(this.monstreActuel);
                    break;*/

            }
        }

        private void lunchBasicAttack()
        {
            int dmg = this.mainForm.CurrentPlayer.basicAttack(this.monstreActuel);

            
            this.lbl_EnemyHealth.Text = this.monstreActuel.Hp.ToString();
            this.lbl_EnemyHealth.ForeColor = Color.Red;

            appendToConsole($"\n\n{this.mainForm.CurrentPlayer.PlayerName}", this.mainForm.CurrentPlayer.ClasseColor);
            appendToConsole($" attacked ", Color.White);
            appendToConsole($"{this.monstreActuel.Name}", Color.Red);
            appendToConsole($" for ", Color.White);
            appendToConsole($"{dmg}", Color.Red);
            appendToConsole($" damage !", Color.White);


            if (!this.monstreActuel.IsDead)
            {
                this.monsterAttack();
            }
            else
            {
                this.mainForm.CurrentPlayer.GainExp(this.monstreActuel);
/*todo               int goldAmount = this.mainForm.CurrentPlayer.GainGold(this.monstreActuel);
*/                appendToConsole($"{this.mainForm.CurrentPlayer.PlayerName}", this.mainForm.CurrentPlayer.ClasseColor);
                appendToConsole($" killed ", Color.White);
                appendToConsole($"{this.monstreActuel.Name}", Color.Red);
                appendToConsole($" and gained ", Color.White);
                appendToConsole($"{this.monstreActuel.Xp}", Color.AliceBlue);
                appendToConsole($" EXP and ", Color.White);
/*todo             appendToConsole($"{goldAmount}", Color.Yellow);
*/                appendToConsole($" Gold !", Color.White);
                /*todo this.mainForm.CurrentPlayer.checkLevelUp();*/
                /*todo this.mainForm.CurrentPlayer.savePlayer();*/

                this.mainForm.loadNewCombat();
            }
            
            this.mainForm.refreshPlayerInfos();
        }

        private void monsterAttack()
        {
            int dmg = this.monstreActuel.attack(this.mainForm.CurrentPlayer);
            
            appendToConsole($"\n\n{this.monstreActuel.Name}", Color.Red);
            appendToConsole($" attacked ", Color.White);
            appendToConsole($"{this.mainForm.CurrentPlayer.PlayerName}", this.mainForm.CurrentPlayer.ClasseColor);
            appendToConsole($" for ", Color.White);
            appendToConsole($"{dmg}", Color.Red);
            appendToConsole($" damage !", Color.White);
            this.mainForm.refreshPlayerInfos();
        }


        public void appendToConsole(string text, Color color)
        {
            this.consoleCtrl.Invoke(new MethodInvoker(delegate
            {
                this.consoleCtrl.WriteOutput(text, color);
                this.consoleCtrl.AutoScroll = true;
            }));

        }

    }
}

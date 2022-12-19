using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int oyunupuan;
        int bilgisayarpuan;
        Random rasgele = new Random();
        int sayaç = 0;
       

        private void button1_Click(object sender, EventArgs e)
        {
            sayaç++;
            if (sayaç == 1)
            {


              
                int a, b, toplam;
                a = rasgele.Next(1, 11);
                b = rasgele.Next(1, 11);
                toplam = a + b;
             
                label1.Text = a.ToString();
                label2.Text = b.ToString();
                label10.Text = toplam.ToString();

              

            }



            
                


            





            if (sayaç == 2)
            {
                int c, toplam;
                c = rasgele.Next(1, 11);
                label3.Text = c.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + c;
                label10.Text = toplam.ToString();


                
                






            }
            if(sayaç==3)
            {

                int d, toplam;

                d = rasgele.Next(1, 11);
                label4.Text = d.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + d;
                label10.Text = toplam.ToString();

            }

            if (label1.Text == "1")
            {

                pictureBox1.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\10.png";

            }



            if (label1.Text == "2")
            {

                pictureBox1.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\1.png";

            }


            if (label1.Text == "3")
            {

                pictureBox1.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\2.png";

            }




            if (label1.Text == "4")
            {

                pictureBox1.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\3.png";

            }



            if (label1.Text == "5")
            {

                pictureBox1.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\4.png";

            }



            if (label1.Text == "6")
            {

                pictureBox1.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\5.png";

            }


            if (label1.Text == "7")
            {

                pictureBox1.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\6.png";

            }



            if (label1.Text == "8")
            {

                pictureBox1.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\7.png";

            }



            if (label1.Text == "9")
            {

                pictureBox1.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\8.png";

            }


            if (label1.Text == "10")
            {

                pictureBox1.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\9.png";

            }




            if (label2.Text == "1")
            {

                pictureBox2.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\10.png";

            }



            if (label2.Text == "2")
            {

                pictureBox2.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\1.png";

            }


            if (label2.Text == "3")
            {

                pictureBox2.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\2.png";

            }




            if (label2.Text == "4")
            {

                pictureBox2.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\3.png";

            }



            if (label2.Text == "5")
            {

                pictureBox2.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\4.png";

            }



            if (label2.Text == "6")
            {

                pictureBox2.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\5.png";

            }


            if (label2.Text == "7")
            {

                pictureBox2.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\6.png";

            }



            if (label2.Text == "8")
            {

                pictureBox2.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\7.png";

            }



            if (label2.Text == "9")
            {

                pictureBox2.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\8.png";

            }


            if (label2.Text == "10")
            {

                pictureBox2.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\9.png";

            }
            if (label3.Text == "1")
            {

                pictureBox3.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\10.png";

            }



            if (label3.Text == "2")
            {

                pictureBox3.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\1.png";

            }


            if (label3.Text == "3")
            {

                pictureBox3.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\2.png";

            }




            if (label3.Text == "4")
            {

                pictureBox3.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\3.png";

            }



            if (label3.Text == "5")
            {

                pictureBox3.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\4.png";

            }



            if (label3.Text == "6")
            {

                pictureBox3.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\5.png";

            }


            if (label3.Text == "7")
            {

                pictureBox3.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\6.png";

            }



            if (label3.Text == "8")
            {

                pictureBox3.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\7.png";

            }



            if (label3.Text == "9")
            {

                pictureBox3.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\8.png";

            }


            if (label3.Text == "10")
            {

                pictureBox3.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\9.png";

            }




            if (label4.Text == "1")
            {

                pictureBox4.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\10.png";

            }



            if (label4.Text == "2")
            {

                pictureBox4.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\1.png";

            }


            if (label4.Text == "3")
            {

                pictureBox4.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\2.png";

            }




            if (label4.Text == "4")
            {

                pictureBox4.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\3.png";

            }



            if (label4.Text == "5")
            {

                pictureBox4.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\4.png";

            }



            if (label4.Text == "6")
            {

                pictureBox4.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\5.png";

            }


            if (label4.Text == "7")
            {

                pictureBox4.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\6.png";

            }



            if (label4.Text == "8")
            {

                pictureBox4.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\7.png";

            }



            if (label4.Text == "9")
            {

                pictureBox4.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\8.png";

            }


            if (label4.Text == "10")
            {

                pictureBox4.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\9.png";

            }













        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, toplam;
            a = rasgele.Next(1, 11);
            b = rasgele.Next(1, 11);
            label5.Text = a.ToString();
            label6.Text = b.ToString();
            toplam = a + b;
            label12.Text = toplam.ToString();


            if (toplam < 16) 
            {
                int c;

                c = rasgele.Next(1, 11);
                label7.Text = c.ToString();
                toplam = toplam + c;
                label12.Text = toplam.ToString();
               
            }
             
            if(toplam<16)
            {
                int d;
                d = rasgele.Next(1,11);
                label8.Text = d.ToString();
                toplam = toplam + d;
                label12.Text = toplam.ToString();
            }






            if (label5.Text == "1")
            {

                pictureBox5.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\10.png";

            }



            if (label5.Text == "2")
            {

                pictureBox5.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\1.png";

            }


            if (label5.Text == "3")
            {

                pictureBox5.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\2.png";

            }




            if (label5.Text == "4")
            {

                pictureBox5.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\3.png";

            }



            if (label5.Text == "5")
            {

                pictureBox5.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\4.png";

            }



            if (label5.Text == "6")
            {

                pictureBox5.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\5.png";

            }


            if (label5.Text == "7")
            {

                pictureBox5.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\6.png";

            }



            if (label5.Text == "8")
            {

                pictureBox5.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\7.png";

            }



            if (label5.Text == "9")
            {

                pictureBox5.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\8.png";

            }


            if (label5.Text == "10")
            {

                pictureBox5.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\9.png";

            }




            if (label6.Text == "1")
            {

                pictureBox6.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\10.png";

            }



            if (label6.Text == "2")
            {

                pictureBox6.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\1.png";

            }


            if (label6.Text == "3")
            {

                pictureBox6.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\2.png";

            }




            if (label6.Text == "4")
            {

                pictureBox6.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\3.png";

            }



            if (label6.Text == "5")
            {

                pictureBox6.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\4.png";

            }



            if (label6.Text == "6")
            {

                pictureBox6.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\5.png";

            }


            if (label6.Text == "7")
            {

                pictureBox6.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\6.png";

            }



            if (label6.Text == "8")
            {

                pictureBox6.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\7.png";

            }



            if (label6.Text == "9")
            {

                pictureBox6.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\8.png";

            }


            if (label6.Text == "10")
            {

                pictureBox6.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\9.png";

            }
            if (label7.Text == "1")
            {

                pictureBox7.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\10.png";

            }



            if (label7.Text == "2")
            {

                pictureBox7.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\1.png";

            }


            if (label7.Text == "3")
            {

                pictureBox7.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\2.png";

            }




            if (label7.Text == "4")
            {

                pictureBox7.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\3.png";

            }



            if (label7.Text == "5")
            {

                pictureBox7.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\4.png";

            }



            if (label7.Text == "6")
            {

                pictureBox7.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\5.png";

            }


            if (label7.Text == "7")
            {

                pictureBox7.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\6.png";

            }



            if (label7.Text == "8")
            {

                pictureBox7.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\7.png";

            }



            if (label7.Text == "9")
            {

                pictureBox7.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\8.png";

            }


            if (label7.Text == "10")
            {

                pictureBox7.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\9.png";

            }




            if (label8.Text == "1")
            {

                pictureBox8.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\10.png";

            }



            if (label8.Text == "2")
            {

                pictureBox8.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\1.png";

            }


            if (label8.Text == "3")
            {

                pictureBox8.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\2.png";

            }




            if (label8.Text == "4")
            {

                pictureBox8.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\3.png";

            }



            if (label8.Text == "5")
            {

                pictureBox8.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\4.png";

            }



            if (label8.Text == "6")
            {

                pictureBox8.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\5.png";

            }


            if (label8.Text == "7")
            {

                pictureBox8.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\6.png";

            }



            if (label8.Text == "8")
            {

                pictureBox8.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\7.png";

            }



            if (label8.Text == "9")
            {

                pictureBox8.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\8.png";

            }


            if (label8.Text == "10")
            {

                pictureBox8.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\9.png";

            }






























        }

        private void button3_Click(object sender, EventArgs e)
        {
            int oyuncutoplam, pctoplam;

            oyuncutoplam = Convert.ToInt32(label10.Text);
            pctoplam = Convert.ToInt32(label12.Text);


            if (oyuncutoplam > pctoplam && oyuncutoplam <= 21) 
            {
                oyunupuan = oyunupuan + 10;
                label15.Text = oyunupuan.ToString();

            }

            if(pctoplam>oyuncutoplam&&pctoplam<=21)
            {
                bilgisayarpuan = bilgisayarpuan + 10;
                label16.Text = bilgisayarpuan.ToString();


            }
            if(pctoplam>21)
            {

                oyunupuan = oyunupuan + 10;
                label15.Text = oyunupuan.ToString();
            }
            if(oyuncutoplam>21)
            {

                bilgisayarpuan = bilgisayarpuan + 10;
                label16.Text = bilgisayarpuan.ToString();

            }
            button3.Enabled = false;
            button4.Enabled = true;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayaç = 0;
            label1.Text = "0";

            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label10.Text = "0";

            label12.Text = "0";
            button4.Enabled = false;
            button3.Enabled = true;
            pictureBox1.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\11.jpg";

            pictureBox1.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\11.jpg";
            pictureBox2.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\11.jpg";
            pictureBox3.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\11.jpg";
            pictureBox4.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\11.jpg";
            pictureBox5.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\11.jpg";
            pictureBox6.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\11.jpg";
            pictureBox7.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\11.jpg";
            pictureBox8.ImageLocation = "C:\\Users\\Demhat\\Desktop\\yeni\\11.jpg";


        }



    }
}

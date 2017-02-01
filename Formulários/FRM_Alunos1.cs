using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Data;
using System.Linq;
using System.Text;
using System.ComponentModel;
using SharpGL;
using System.Windows.Forms.Integration;
using System.Windows.Media.Media3D;
namespace MiniPaint
{

    public partial class FRM_Alunos1 : Form
    {
        clsResize _form_resize;
        public FRM_Alunos1()
        {
            InitializeComponent();
            _form_resize = new clsResize(this);
            this.Load += _Load;
            this.Resize += _Resize;
            this.ClientSizeChanged += ESSE1_ClientSizeChanged;
          

            
        }
        ~FRM_Alunos1()
        {
            System.Console.WriteLine("First's destructor is called");
        }
        void ESSE1_ClientSizeChanged(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        private void Form1_Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
            _form_resize._resize();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();

        }


        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            System.Diagnostics.Process.Start("calc");

        }

        private void calibrarCanetaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {


        }





        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(label1);
            panel2.Controls.Add(label2);

        }




        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wiimote_Mouse1 WM = new Wiimote_Mouse1();
            WM.Show();
        }


        private void volumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Esfera_IMG_Volume)
                ;
            Esfera_IMG_Volume.BringToFront();
            Esfera_IMG_Volume.Visible = true;
            panel2.Controls.Add(label2);

            UserControl1 ALC = new UserControl1();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);


        }

        private void volumeDoCuboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cubo_Volume_IMG
                );
            Cubo_Volume_IMG.BringToFront();
            Cubo_Volume_IMG.Visible = true;
            panel2.Controls.Add(label2);
            cubo PA = new cubo();
            ElementHost hostPA = new ElementHost();
            hostPA.Dock = DockStyle.Fill;
            hostPA.Child = PA;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostPA);



        }

        private void áreaDoParalelepípedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Paralelepipedo_IMG_Area
                );
            Paralelepipedo_IMG_Area.BringToFront();
            Paralelepipedo_IMG_Area.Visible = true;
            panel2.Controls.Add(label2);

            Paralelepipedo_Area PA = new Paralelepipedo_Area();
            ElementHost hostPA = new ElementHost();
            hostPA.Dock = DockStyle.Fill;
            hostPA.Child = PA;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostPA);

        }

        private void volumeDoParalelepípedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Paralelepipedo_IMG_Volume
                );
            Paralelepipedo_IMG_Volume.BringToFront();
            Paralelepipedo_IMG_Volume.Visible = true;
            panel2.Controls.Add(label2);
            UserControl3 uc3 = new UserControl3();
            ElementHost host3 = new ElementHost();
            host3.Dock = DockStyle.Fill;
            host3.Child = uc3;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host3);


        }

        private void volumeDoConeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            btn_Cone_Geral.Visible = false;
            panel1.Controls.Add(Cone_IMG_Volume);
            panel1.Controls.Add(BTN_Cone_Volume);
            Cone_IMG_Volume.BringToFront();
            Cone_IMG_Volume.Visible = true;
            BTN_Cone_Volume.Visible = false;
            UserControl2 uc4 = new UserControl2();
            ElementHost host4 = new ElementHost();
            host4.Dock = DockStyle.Fill;
            host4.Child = uc4;

            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host4);

        }

        private void volumeDoCilindroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl4 uc4 = new UserControl4();
            ElementHost host4 = new ElementHost();
            host4.Dock = DockStyle.Fill;
            host4.Child = uc4;

            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host4);
            panel1.Controls.Clear();
            panel1.Controls.Add(Cilindro_IMG_Volume);
            Cilindro_IMG_Volume.Visible = true;
            Cilindro_IMG_Volume.BringToFront();




        }

        private void volumeDaPirâmideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Piramide_IMG_Volume
                );
            Piramide_IMG_Volume.BringToFront();
            Piramide_IMG_Volume.Visible = true;
            panel2.Controls.Add(label2);
            UserControl5 uc6 = new UserControl5();
            ElementHost host6 = new ElementHost();
            host6.Dock = DockStyle.Fill;
            host6.Child = uc6;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host6);
            groupBox1.Visible = true;
            uc6.camera.CameraController.CameraUpDirection = new Vector3D(-3.550, 6.047, -5.082);
            uc6.camera.CameraController.CameraPosition = new Point3D(-5.981, 2.305, -8.024);
            uc6.camera.CameraController.CameraLookDirection = new Vector3D(5.981, -2.305, 8.024);




        }

        private void diagonalDoCuboToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Diagonal_IMG
                );
            Diagonal_IMG.BringToFront();
            Diagonal_IMG.Visible = true;
            panel2.Controls.Add(label2);

            Cubo_Diagonal CD = new Cubo_Diagonal();
            ElementHost hostCD = new ElementHost();
            hostCD.Dock = DockStyle.Fill;
            hostCD.Child = CD;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostCD);
            groupBox1.Visible = true;



            CD.camera.CameraController.CameraUpDirection = new Vector3D(-0.622, 0.023, 0.783);
            CD.camera.CameraController.CameraPosition = new Point3D(-11.935, 0.443, 2.675);

            CD.camera.CameraController.CameraLookDirection = new Vector3D(11.935, -0.443, -2.675);
        }

        private void prismaTriangularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void poliedrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void áreaTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cubo_AreaTotal_IMG
                );
            Cubo_AreaTotal_IMG.BringToFront();
            Cubo_AreaTotal_IMG.Visible = true;
            panel2.Controls.Add(label2);

            AreaLateral_Cubo AL = new AreaLateral_Cubo();
            ElementHost hostAL1 = new ElementHost();
            hostAL1.Dock = DockStyle.Fill;
            hostAL1.Child = AL;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostAL1);


        }

        private void áreaLateralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cubo_AreaLateral
                );
            Cubo_AreaLateral.BringToFront();
            Cubo_AreaLateral.Visible = true;
            panel2.Controls.Add(label2);

            AreaTotal_Cubo AT = new AreaTotal_Cubo();
            ElementHost hostAT1 = new ElementHost();
            hostAT1.Dock = DockStyle.Fill;
            hostAT1.Child = AT;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostAT1);


        }

        private void áreaDeSuperfícieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Esfera_IMG_AreaSuperficie
                );
            Esfera_IMG_AreaSuperficie.BringToFront();
            Esfera_IMG_AreaSuperficie.Visible = true;
            panel2.Controls.Add(label2);

            AreaDeSuperficie_Esfera ALC = new AreaDeSuperficie_Esfera();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);



        }

        private void áreaDoCilindroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void áreaLateralToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cilindro_IMG_AreaLateral);
            Cilindro_IMG_AreaLateral.BringToFront();
            Cilindro_IMG_AreaLateral.Visible = true;
            panel2.Controls.Add(label2);

            AreaLateralCilindro ALC = new AreaLateralCilindro();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);


        }

        private void áreaTotalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cilindro_IMG_AreaTotal);
            Cilindro_IMG_AreaTotal.BringToFront();
            Cilindro_IMG_AreaTotal.Visible = true;
            panel2.Controls.Add(label2);

            AreaTotalCilindro ALC = new AreaTotalCilindro();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);


        }

        private void áreaLateralToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear();
            panel1.Controls.Clear();
            panel2.Controls.Add(label2);

            BTN_Geratriz.Visible = false;
            panel1.Controls.Add(Cone_IMG_Geratriz);
            Cone_IMG_Geratriz.Visible = true;
            panel1.Controls.Add(BTN_Cone_AreaLateral);
            BTN_Cone_AreaLateral.Visible = true;
            BTN_Cone_AreaLateral.BringToFront();


        }

        private void áreaTotalToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void áreaDaPirâmideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiniPaint51 form1 = new MiniPaint51();
            form1.Show();
            FRM_Alunos1 form = new FRM_Alunos1();
            this.Hide();
        }

        private void logoffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiniPaint51 form1 = new MiniPaint51();
            form1.Show();
            FRM_Alunos1 form = new FRM_Alunos1();
            this.Hide();
        }

        private void áreaDaPirâmideToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Piramide_IMG_apotema
                );
            Piramide_IMG_apotema.BringToFront();
            Piramide_IMG_apotema.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Piramide_AreaLateral);
            BTN_Piramide_AreaLateral.Visible = true;
            BTN_Piramide_AreaLateral.BringToFront();

            Geratriz_Piramide GP = new Geratriz_Piramide();
            ElementHost hostGP = new ElementHost();
            hostGP.Dock = DockStyle.Fill;
            hostGP.Child = GP;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostGP);

            GP.camera.CameraController.CameraUpDirection = new Vector3D(-3.550, 6.047, -5.082);
            GP.camera.CameraController.CameraPosition = new Point3D(-5.981, 2.305, -8.024);
            GP.camera.CameraController.CameraLookDirection = new Vector3D(5.981, -2.305, 8.024);

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MiniPaint51 form1 = new MiniPaint51();
            form1.Show();
            FRM_Alunos1 form = new FRM_Alunos1();
            this.Hide();
        }

        private void setorCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Esfera_IMG_Secao
                );
            Esfera_IMG_Secao.BringToFront();
            Esfera_IMG_Secao.Visible = true;
            panel2.Controls.Add(label2);

            Esfera_Setor ALC = new Esfera_Setor();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);


        }

        private void volumeDoPrismaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Volume_Prisma
                );
            Volume_Prisma.BringToFront();
            Volume_Prisma.Visible = true;
            panel2.Controls.Add(label2);
            Prisma pri = new Prisma();
            ElementHost hostPR = new ElementHost();
            hostPR.Dock = DockStyle.Fill;
            hostPR.Child = pri;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostPR);

            pri.camera.CameraController.CameraLookDirection = new Vector3D(4.267, -8.605, -7.403);
            pri.camera.CameraController.CameraUpDirection = new Vector3D(-0.104, 0.209, 0.972);
            pri.camera.CameraController.CameraPosition = new Point3D(-4.267, 8.605, 7.403);

        }

        private void diagonalDoParalelepípedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Paralelepipedo_IMG_Diagonal
                );
            Paralelepipedo_IMG_Diagonal.BringToFront();
            Paralelepipedo_IMG_Diagonal.Visible = true;
            panel2.Controls.Add(label2);

            Diagonal_caixa DC = new Diagonal_caixa();
            ElementHost hostDC = new ElementHost();
            hostDC.Dock = DockStyle.Fill;
            hostDC.Child = DC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostDC);

        }

        private void semelhançaDeTriângulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Sem_Triang_IMG
                );
            Sem_Triang_IMG.BringToFront();
            Sem_Triang_IMG.Visible = true;
            panel2.Controls.Add(label2);

            Sem_Triang ST = new Sem_Triang();
            ElementHost hostST = new ElementHost();
            hostST.Dock = DockStyle.Fill;
            hostST.Child = ST;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostST);
        }

        private void polígonosInscritosNaCircuferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Poligono_IMG_Geral
                );
            Poligono_IMG_Geral.BringToFront();
            Poligono_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);

            AreaDeSuperficie_Esfera ALC = new AreaDeSuperficie_Esfera();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);
            TrianguloeQuadCircuferencia T = new TrianguloeQuadCircuferencia();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = T;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void quadradoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void retânguloToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void triânguloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void retânguloToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Retangulo_Area RA = new Retangulo_Area();
            ElementHost hostRA = new ElementHost();
            hostRA.Dock = DockStyle.Fill;
            hostRA.Child = RA;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostRA);
        }

        private void triânguloToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

            Triangulo_Area TA = new Triangulo_Area();
            ElementHost hostRA = new ElementHost();
            hostRA.Dock = DockStyle.Fill;
            hostRA.Child = TA;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostRA);
            TA.camera.CameraController.CameraLookDirection = new Vector3D(-3.840, -2.162, -25.310);
            TA.camera.CameraController.CameraUpDirection = new Vector3D(-0.422, 0.238, 0.875);
            TA.camera.CameraController.CameraPosition = new Point3D(3.840, 2.162, 25.310);
        }

        private void quadradoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Quadrado_Area QA = new Quadrado_Area();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = QA;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void posiçõesRetaPlanoEPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Retas_IMG_Geral
                );
            Retas_IMG_Geral.BringToFront();
            Retas_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Retas_Concorrentes);
            BTN_Retas_Concorrentes.Visible = true;
            BTN_Retas_Concorrentes.BringToFront();
            panel1.Controls.Add(BTN_Retas_Paralelas);
            BTN_Retas_Paralelas.Visible = true;
            BTN_Retas_Paralelas.BringToFront();
            panel1.Controls.Add(BTN_Retas_Perp);
            BTN_Retas_Perp.Visible = true;
            BTN_Retas_Perp.BringToFront();

        }

        private void retasParalelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Retas_IMG_Geral
                );
            Retas_IMG_Geral.BringToFront();
            Retas_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Retas_Concorrentes);
            BTN_Retas_Concorrentes.Visible = true;
            BTN_Retas_Concorrentes.BringToFront();
            panel1.Controls.Add(BTN_Retas_Paralelas);
            BTN_Retas_Paralelas.Visible = true;
            BTN_Retas_Paralelas.BringToFront();
            panel1.Controls.Add(BTN_Retas_Perp);
            BTN_Retas_Perp.Visible = true;
            BTN_Retas_Perp.BringToFront();
            Posições_Retas PR = new Posições_Retas();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = PR;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void retasConcorrentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Retas_IMG_Geral
                );
            Retas_IMG_Geral.BringToFront();
            Retas_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Retas_Concorrentes);
            BTN_Retas_Concorrentes.Visible = true;
            BTN_Retas_Concorrentes.BringToFront();
            panel1.Controls.Add(BTN_Retas_Paralelas);
            BTN_Retas_Paralelas.Visible = true;
            BTN_Retas_Paralelas.BringToFront();
            panel1.Controls.Add(BTN_Retas_Perp);
            BTN_Retas_Perp.Visible = true;
            BTN_Retas_Perp.BringToFront();
            Posicoes_Retas_Concorrentes PRC = new Posicoes_Retas_Concorrentes();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = PRC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void retasPerpendicularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Retas_IMG_Geral
                );
            Retas_IMG_Geral.BringToFront();
            Retas_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Retas_Concorrentes);
            BTN_Retas_Concorrentes.Visible = true;
            BTN_Retas_Concorrentes.BringToFront();
            panel1.Controls.Add(BTN_Retas_Paralelas);
            BTN_Retas_Paralelas.Visible = true;
            BTN_Retas_Paralelas.BringToFront();
            panel1.Controls.Add(BTN_Retas_Perp);
            BTN_Retas_Perp.Visible = true;
            BTN_Retas_Perp.BringToFront();
            RetasPerpendiculares RP = new RetasPerpendiculares();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = RP;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void paralelismoNoEspaçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(PlParalelo_IMG
                );
            PlParalelo_IMG.BringToFront();
            PlParalelo_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Planos_Paralelos);
            BTN_Planos_Paralelos.Visible = true;
            BTN_Planos_Paralelos.BringToFront();
            Planos_Retas PR = new Planos_Retas();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = PR;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void planosParalelosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(PlParalelo_IMG
                );
            PlParalelo_IMG.BringToFront();
            PlParalelo_IMG.Visible = true;
            panel2.Controls.Add(label2);

            Planos_Retas PR = new Planos_Retas();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = PR;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void planosConcorrentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(PlConcorrente_IMG
                );
            PlConcorrente_IMG.BringToFront();
            PlConcorrente_IMG.Visible = true;
            panel1.Controls.Add(voltar);
            voltar.Visible = true;
            voltar.BringToFront();
            panel2.Controls.Add(label2);

            Pl_Concorrentes PL = new Pl_Concorrentes();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = PL;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void relaçãoDeEulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Euler_IMG
                );
            Euler_IMG.BringToFront();
            Euler_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Octaedro);
            BTN_Octaedro.Visible = true;
            BTN_Octaedro.BringToFront();
        }

        private void octaedroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Octaedro_IMG
                );
            Octaedro_IMG.BringToFront();
            Octaedro_IMG.Visible = true;
            panel2.Controls.Add(label2);

            Icosaedro I = new Icosaedro();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = I;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void icosaedroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Isosaedro_IMG
                );
            Isosaedro_IMG.BringToFront();
            Isosaedro_IMG.Visible = true;
            panel2.Controls.Add(label2);

            Icosaedro1 I = new Icosaedro1();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = I;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void dodecaedroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Dodecaedro_IMG
                );
            Dodecaedro_IMG.BringToFront();
            Dodecaedro_IMG.Visible = true;
            panel2.Controls.Add(label2);

            Dodecaedro D = new Dodecaedro();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = D;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void tetraedroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Tetraedro_IMG
                );
            Tetraedro_IMG.BringToFront();
            Tetraedro_IMG.Visible = true;
            panel2.Controls.Add(label2);
            Tetraedro D = new Tetraedro();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = D;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void esferaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Esfera_IMG_Geral);
            Esfera_IMG_Geral.BringToFront();
            Esfera_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Esfera_Geral);
            BTN_Esfera_Geral.Visible = true;
            BTN_Esfera_Geral.BringToFront();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }

        private void ESSE1_Load(object sender, EventArgs e)
        {

        }

        private void cilindroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cilindro_IMG_Geral);
            Cilindro_IMG_Geral.BringToFront();
            Cilindro_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Cilindro_Geral);
            BTN_Cilindro_Geral.Visible = true;
            BTN_Cilindro_Geral.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AreaLateralCilindro ALC = new AreaLateralCilindro();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
      
      
 
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void corposRedondosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl2 uc4 = new UserControl2();
            ElementHost host4 = new ElementHost();
            host4.Dock = DockStyle.Fill;
            host4.Child = uc4;

            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host4);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void coneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cone_IMG);
            Cone_IMG.BringToFront();
            Cone_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(btn_Cone_Geral);
            btn_Cone_Geral.Visible = true;
            btn_Cone_Geral.BringToFront();
        }

        private void Cone_Geral_Click(object sender, EventArgs e)
        {

        }

        private void Botao_Cone_Geral_Click(object sender, EventArgs e)
        {

        }

        private void áreaDoConeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cone_Geral_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            btn_Cone_Geral.Visible = false;
            panel1.Controls.Add(Cone_IMG_Volume);
            panel1.Controls.Add(BTN_Cone_Volume);
            Cone_IMG_Volume.BringToFront();
            Cone_IMG_Volume.Visible = true;
            BTN_Cone_Volume.Visible = true;
            BTN_Cone_Volume.BringToFront();
            panel1.Controls.Add(voltar24);
            voltar24.Visible = true;
            voltar24.BringToFront();
            UserControl2 uc4 = new UserControl2();
            ElementHost host4 = new ElementHost();
            host4.Dock = DockStyle.Fill;
            host4.Child = uc4;

            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host4);
        }

        private void BTN_Cone_Volume_Click(object sender, EventArgs e)
        {

            AreaLateralCone uc4 = new AreaLateralCone();
            ElementHost host4 = new ElementHost();
            host4.Dock = DockStyle.Fill;
            host4.Child = uc4;

            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host4);
            panel1.Controls.Clear();
            BTN_Cone_Volume.Visible = false;
            panel1.Controls.Add(Cone_IMG_Geratriz);
            Cone_IMG_Geratriz.Visible = true;
            panel1.Controls.Add(BTN_Cone_AreaLateral);
            BTN_Cone_AreaLateral.Visible = true;
            BTN_Cone_AreaLateral.BringToFront();
            panel1.Controls.Add(voltar25);
            voltar25.Visible = true;
            voltar25.BringToFront();
        }

        private void BTN_Geratriz_Click(object sender, EventArgs e)
        {

        }

        private void Cone_IMG_Geratriz_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Cone_AreaLateral_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(Cone_IMG_AreaLateral);
            Cone_IMG_AreaLateral.Visible = true;
            Cone_IMG_AreaLateral.BringToFront();
            panel1.Controls.Add(BTN_Cone_AreaTotal);
            BTN_Cone_AreaTotal.Visible = true;
            BTN_Cone_AreaTotal.BringToFront();
            panel1.Controls.Add(voltar26);
            voltar26.Visible = true;
            voltar26.BringToFront();

        }

        private void BTN_Cone_AreaTotal_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(Cone_IMG_AreaTotal);
            Cone_IMG_AreaTotal.Visible = true;
            Cone_IMG_AreaTotal.BringToFront();
            panel1.Controls.Add(Demo_Cone);
            Demo_Cone.Visible = true;
            Demo_Cone.BringToFront();
            panel1.Controls.Add(voltar27);
            voltar27.Visible = true;
            voltar27.BringToFront();
            Demo_Cone.Visible = false;
        }

        private void Demo_Cone_Click(object sender, EventArgs e)
        {
            AreaLateralCone uc4 = new AreaLateralCone();
            ElementHost host4 = new ElementHost();
            host4.Dock = DockStyle.Fill;
            host4.Child = uc4;

            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host4);
        }

        private void Cone_IMG_AreaTotal_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Cilindro_Geral_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cilindro_IMG_Volume);
            Cilindro_IMG_Volume.BringToFront();
            Cilindro_IMG_Volume.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Cilindro_AreaLateral);
            BTN_Cilindro_AreaLateral.Visible = true;
            BTN_Cilindro_AreaLateral.BringToFront();
            panel1.Controls.Add(voltar19);
            voltar19.Visible = true;
            voltar19.BringToFront();
            UserControl4 uc4 = new UserControl4();
            ElementHost host4 = new ElementHost();
            host4.Dock = DockStyle.Fill;
            host4.Child = uc4;

            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host4);
            panel1.Controls.Add(voltar20);
            voltar20.Visible = true;
            voltar20.BringToFront();
        }

        private void BTN_Cilindro_Volume_Click(object sender, EventArgs e)
        {



        }

        private void BTN_Cilindro_AreaLateral_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cilindro_IMG_AreaLateral);
            Cilindro_IMG_AreaLateral.BringToFront();
            Cilindro_IMG_AreaLateral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Cilindro_AreaTotal);
            BTN_Cilindro_AreaTotal.Visible = true;
            BTN_Cilindro_AreaTotal.BringToFront();
            AreaLateralCilindro ALC = new AreaLateralCilindro();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);
            panel1.Controls.Add(voltar21);
            voltar21.Visible = true;
            voltar21.BringToFront();
        }

        private void BTN_Cilindro_AreaTotal_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cilindro_IMG_AreaTotal);
            Cilindro_IMG_AreaTotal.BringToFront();
            Cilindro_IMG_AreaTotal.Visible = true;
            panel2.Controls.Add(label2);

            AreaTotalCilindro ALC = new AreaTotalCilindro();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);
            panel1.Controls.Add(voltar22);
            voltar22.Visible = true;
            voltar22.BringToFront();
        }

        private void BTN_Esfera_Geral_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Esfera_IMG_AreaSuperficie
                );
            Esfera_IMG_AreaSuperficie.BringToFront();
            Esfera_IMG_AreaSuperficie.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Esfera_AreaSuperficie);
            BTN_Esfera_AreaSuperficie.Visible = true;
            BTN_Esfera_AreaSuperficie.BringToFront();
            AreaDeSuperficie_Esfera ALC = new AreaDeSuperficie_Esfera();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);
            panel1.Controls.Add(voltar28);
            voltar28.Visible = true;
            voltar28.BringToFront();
        }

        private void BTN_Esfera_AreaSuperficie_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Esfera_IMG_Volume)
                ;
            Esfera_IMG_Volume.BringToFront();
            Esfera_IMG_Volume.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Esfera_Volume);
            BTN_Esfera_Volume.Visible = true;
            BTN_Esfera_Volume.BringToFront();
            UserControl1 ALC = new UserControl1();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);
            panel1.Controls.Add(voltar29);
            voltar29.Visible = true;
            voltar29.BringToFront();
        }

        private void BTN_Esfera_Volume_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Esfera_IMG_Secao
                );
            Esfera_IMG_Secao.BringToFront();
            Esfera_IMG_Secao.Visible = true;
            panel2.Controls.Add(label2);

            Esfera_Setor ALC = new Esfera_Setor();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);
            panel1.Controls.Add(voltar30);
            voltar30.Visible = true;
            voltar30.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Posicoes_Retas_Concorrentes PRC = new Posicoes_Retas_Concorrentes();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = PRC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void Sem_Triang_IMG_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Retas_Paralelas_Click(object sender, EventArgs e)
        {
            Posições_Retas PR = new Posições_Retas();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = PR;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void BTN_Retas_Perp_Click(object sender, EventArgs e)
        {
            RetasPerpendiculares RP = new RetasPerpendiculares();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = RP;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void BTN_Planos_Paralelos_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(PlConcorrente_IMG
                );
            PlConcorrente_IMG.BringToFront();
            PlConcorrente_IMG.Visible = true;
            panel1.Controls.Add(voltar);
            voltar.Visible = true;
            voltar.BringToFront();
            panel2.Controls.Add(label2);

            Pl_Concorrentes PL = new Pl_Concorrentes();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = PL;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void figurasGeométricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(FIG_IMG_Geral
                );
            FIG_IMG_Geral.BringToFront();
            FIG_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_AreaQuadrado);
            BTN_AreaQuadrado.Visible = true;
            BTN_AreaQuadrado.BringToFront();
            panel1.Controls.Add(BTN_AreaRetangulo);
            BTN_AreaRetangulo.Visible = true;
            BTN_AreaRetangulo.BringToFront();
            panel1.Controls.Add(BTN_AreaTriangulo);
            BTN_AreaTriangulo.Visible = true;
            BTN_AreaTriangulo.BringToFront();
        }

        private void BTN_AreaRetangulo_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(AreaR_IMG
                );
            AreaR_IMG.BringToFront();
            AreaR_IMG.Visible = true;
            Retangulo_Area RA = new Retangulo_Area();
            ElementHost hostRA = new ElementHost();
            hostRA.Dock = DockStyle.Fill;
            hostRA.Child = RA;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostRA);
            panel1.Controls.Add(voltar31);
            voltar31.Visible = true;
            voltar31.BringToFront();
        }

        private void BTN_AreaTriangulo_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(AreaT_IMG
               );
            AreaT_IMG.BringToFront();
            AreaT_IMG.Visible = true;
            Triangulo_Area TA = new Triangulo_Area();
            ElementHost hostRA = new ElementHost();
            hostRA.Dock = DockStyle.Fill;
            hostRA.Child = TA;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostRA);
            TA.camera.CameraController.CameraLookDirection = new Vector3D(-3.840, -2.162, -25.310);
            TA.camera.CameraController.CameraUpDirection = new Vector3D(-0.422, 0.238, 0.875);
            TA.camera.CameraController.CameraPosition = new Point3D(3.840, 2.162, 25.310);
            panel1.Controls.Add(voltar31);
            voltar31.Visible = true;
            voltar31.BringToFront();
        }

        private void BTN_AreaQuadrado_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(AreaQ_IMG
                );
            AreaQ_IMG.BringToFront();
            AreaQ_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(voltar31);
            voltar31.Visible = true;
            voltar31.BringToFront();
            Quadrado_Area QA = new Quadrado_Area();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = QA;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void poliedrosTeoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Poliedro_IMG
                );
            Poliedro_IMG.BringToFront();
            Poliedro_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Euler);
            BTN_Euler.Visible = true;
            BTN_Euler.BringToFront();

        }

        private void BTN_Euler_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Euler_IMG
                );
            Euler_IMG.BringToFront();
            Euler_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Octaedro);
            BTN_Octaedro.Visible = true;
            BTN_Octaedro.BringToFront();
            panel1.Controls.Add(voltar14);
            voltar14.Visible = true;
            voltar14.BringToFront();
        }

        private void BTN_Octaedro_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Octaedro_IMG
                );
            Octaedro_IMG.BringToFront();
            Octaedro_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Icosaedro);
            BTN_Icosaedro.Visible = true;
            BTN_Icosaedro.BringToFront();
            Icosaedro I = new Icosaedro();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = I;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
            panel1.Controls.Add(voltar15);
            voltar15.Visible = true;
            voltar15.BringToFront();
        }

        private void BTN_Icosaedro_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Isosaedro_IMG
                );
            Isosaedro_IMG.BringToFront();
            Isosaedro_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Dodecaedro);
            BTN_Dodecaedro.Visible = true;
            BTN_Dodecaedro.BringToFront();
            Icosaedro1 I = new Icosaedro1();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = I;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
            panel1.Controls.Add(voltar16);
            voltar16.Visible = true;
            voltar16.BringToFront();
        }

        private void BTN_Dodecaedro_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Dodecaedro_IMG
                );
            Dodecaedro_IMG.BringToFront();
            Dodecaedro_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Tetraedro);
            BTN_Tetraedro.Visible = true;
            BTN_Tetraedro.BringToFront();
            Dodecaedro D = new Dodecaedro();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = D;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
            panel1.Controls.Add(voltar17);
            voltar17.Visible = true;
            voltar17.BringToFront();
        }

        private void BTN_Tetraedro_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Tetraedro_IMG
                );
            Tetraedro_IMG.BringToFront();
            Tetraedro_IMG.Visible = true;
            panel2.Controls.Add(label2);
            Tetraedro D = new Tetraedro();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = D;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
            panel1.Controls.Add(voltar18);
            voltar18.Visible = true;
            voltar18.BringToFront();
        }

        private void cuboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cubo_IMG_Geral
                );
            Cubo_IMG_Geral.BringToFront();
            Cubo_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Diagonal);
            BTN_Diagonal.Visible = true;
            BTN_Diagonal.BringToFront();
        }

        private void BTN_Diagonal_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Diagonal_IMG
                );
            Diagonal_IMG.BringToFront();
            Diagonal_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Cubo_AreaTotal);
            BTN_Cubo_AreaTotal.Visible = true;
            BTN_Cubo_AreaTotal.BringToFront();
            Cubo_Diagonal CD = new Cubo_Diagonal();
            ElementHost hostCD = new ElementHost();
            hostCD.Dock = DockStyle.Fill;
            hostCD.Child = CD;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostCD);
            groupBox1.Visible = true;
            CD.camera.CameraController.CameraUpDirection = new Vector3D(-0.622, 0.023, 0.783);
            CD.camera.CameraController.CameraPosition = new Point3D(-11.935, 0.443, 2.675);

            CD.camera.CameraController.CameraLookDirection = new Vector3D(11.935, -0.443, -2.675);
            panel1.Controls.Add(voltar10);
            voltar10.Visible = true;
            voltar10.BringToFront();
        }

        private void BTN_Cubo_AreaTotal_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cubo_AreaTotal_IMG
                );
            Cubo_AreaTotal_IMG.BringToFront();
            Cubo_AreaTotal_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_AreaLateral);
            BTN_AreaLateral.Visible = true;
            BTN_AreaLateral.BringToFront();
            AreaLateral_Cubo AL = new AreaLateral_Cubo();
            ElementHost hostAL1 = new ElementHost();
            hostAL1.Dock = DockStyle.Fill;
            hostAL1.Child = AL;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostAL1);
            panel1.Controls.Add(voltar11);
            voltar11.Visible = true;
            voltar11.BringToFront();

        }

        private void BTN_AreaLateral_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cubo_AreaLateral
                );
            Cubo_AreaLateral.BringToFront();
            Cubo_AreaLateral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Cubo_Volume);
            BTN_Cubo_Volume.Visible = true;
            BTN_Cubo_Volume.BringToFront();
            AreaTotal_Cubo AT = new AreaTotal_Cubo();
            ElementHost hostAT1 = new ElementHost();
            hostAT1.Dock = DockStyle.Fill;
            hostAT1.Child = AT;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostAT1);
            panel1.Controls.Add(voltar12);
            voltar12.Visible = true;
            voltar12.BringToFront();


        }

        private void BTN_Cubo_Volume_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cubo_Volume_IMG
                );
            Cubo_Volume_IMG.BringToFront();
            Cubo_Volume_IMG.Visible = true;
            panel2.Controls.Add(label2);
            cubo PA = new cubo();
            ElementHost hostPA = new ElementHost();
            hostPA.Dock = DockStyle.Fill;
            hostPA.Child = PA;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostPA);
            panel1.Controls.Add(voltar13);
            voltar13.Visible = true;
            voltar13.BringToFront();

        }

        private void prismasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Prisma_IMG_Geral
                );
            Prisma_IMG_Geral.BringToFront();
            Prisma_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Volume);
            BTN_Volume.Visible = true;
            BTN_Volume.BringToFront();

        }

        private void BTN_Volume_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Volume_Prisma
                );
            Volume_Prisma.BringToFront();
            Volume_Prisma.Visible = true;
            panel1.Controls.Add(voltar2);
            voltar2.Visible = true;
            voltar2.BringToFront();
            panel2.Controls.Add(label2);

            Prisma pri = new Prisma();
            ElementHost hostPR = new ElementHost();
            hostPR.Dock = DockStyle.Fill;
            hostPR.Child = pri;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostPR);

            pri.camera.CameraController.CameraLookDirection = new Vector3D(4.267, -8.605, -7.403);
            pri.camera.CameraController.CameraUpDirection = new Vector3D(-0.104, 0.209, 0.972);
            pri.camera.CameraController.CameraPosition = new Point3D(-4.267, 8.605, 7.403);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Paralelepipedo_IMG_Diagonal
                );
            Paralelepipedo_IMG_Diagonal.BringToFront();
            Paralelepipedo_IMG_Diagonal.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_ParalelepipedoArea);
            BTN_ParalelepipedoArea.Visible = true;
            BTN_ParalelepipedoArea.BringToFront();
            Diagonal_caixa DC = new Diagonal_caixa();
            ElementHost hostDC = new ElementHost();
            hostDC.Dock = DockStyle.Fill;
            hostDC.Child = DC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostDC);
            panel1.Controls.Add(voltar7);
            voltar7.Visible = true;
            voltar7.BringToFront();
        }

        private void paralelepípedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Paralelepipedo_IMG_Geral
                );
            Paralelepipedo_IMG_Geral.BringToFront();
            Paralelepipedo_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Paralelepipedo_Diagonal);
            BTN_Paralelepipedo_Diagonal.Visible = true;
            BTN_Paralelepipedo_Diagonal.BringToFront();
        }

        private void BTN_ParalelepipedoArea_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Paralelepipedo_IMG_Area
                );
            Paralelepipedo_IMG_Area.BringToFront();
            Paralelepipedo_IMG_Area.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Paralelepipedo_IMG_Volume);
            BTN_Paralelepipedo_IMG_Volume.Visible = true;
            BTN_Paralelepipedo_IMG_Volume.BringToFront();
            Paralelepipedo_Area PA = new Paralelepipedo_Area();
            ElementHost hostPA = new ElementHost();
            hostPA.Dock = DockStyle.Fill;
            hostPA.Child = PA;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostPA);
            panel1.Controls.Add(voltar8);
            voltar8.Visible = true;
            voltar8.BringToFront();
        }

        private void BTN_Paralelepipedo_IMG_Volume_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Paralelepipedo_IMG_Volume
                );
            Paralelepipedo_IMG_Volume.BringToFront();
            Paralelepipedo_IMG_Volume.Visible = true;
            panel2.Controls.Add(label2);
            UserControl3 uc3 = new UserControl3();
            ElementHost host3 = new ElementHost();
            host3.Dock = DockStyle.Fill;
            host3.Child = uc3;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host3);
            panel1.Controls.Add(voltar9);
            voltar9.Visible = true;
            voltar9.BringToFront();
        }

        private void pirâmidesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Piramide_IMG_Geral
                );
            Piramide_IMG_Geral.BringToFront();
            Piramide_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Apotema);
            BTN_Apotema.Visible = true;
            BTN_Apotema.BringToFront();
        }

        private void BTN_Apotema_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Piramide_IMG_apotema
                );
            Piramide_IMG_apotema.BringToFront();
            Piramide_IMG_apotema.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Piramide_AreaLateral);
            BTN_Piramide_AreaLateral.Visible = true;
            BTN_Piramide_AreaLateral.BringToFront();
            panel1.Controls.Add(voltar3);
            voltar3.Visible = true;
            voltar3.BringToFront();
        }

        private void BTN_Piramide_AreaLateral_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Piramide_IMG_AreaLateral
                );
            Piramide_IMG_AreaLateral.BringToFront();
            Piramide_IMG_AreaLateral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Piramide_AreaTotal);
            BTN_Piramide_AreaTotal.Visible = true;
            BTN_Piramide_AreaTotal.BringToFront();
            panel1.Controls.Add(voltar4);
            voltar4.Visible = true;
            voltar4.BringToFront();
        }

        private void BTN_Piramide_AreaTotal_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Piramide_IMG_AreaTotal
                );
            Piramide_IMG_AreaTotal.BringToFront();
            Piramide_IMG_AreaTotal.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Piramide_Volume);
            BTN_Piramide_Volume.Visible = true;
            BTN_Piramide_Volume.BringToFront();
            Geratriz_Piramide GP = new Geratriz_Piramide();
            ElementHost hostGP = new ElementHost();
            hostGP.Dock = DockStyle.Fill;
            hostGP.Child = GP;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostGP);
            panel1.Controls.Add(voltar5);
            voltar5.Visible = true;
            voltar5.BringToFront();
            GP.camera.CameraController.CameraUpDirection = new Vector3D(-3.550, 6.047, -5.082);
            GP.camera.CameraController.CameraPosition = new Point3D(-5.981, 2.305, -8.024);
            GP.camera.CameraController.CameraLookDirection = new Vector3D(5.981, -2.305, 8.024);

        }

        private void BTN_Piramide_Volume_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Piramide_IMG_Volume
                );
            Piramide_IMG_Volume.BringToFront();
            Piramide_IMG_Volume.Visible = true;
            panel2.Controls.Add(label2);
            UserControl5 uc6 = new UserControl5();
            ElementHost host6 = new ElementHost();
            host6.Dock = DockStyle.Fill;
            host6.Child = uc6;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host6);
            groupBox1.Visible = true;
            uc6.camera.CameraController.CameraUpDirection = new Vector3D(-3.550, 6.047, -5.082);
            uc6.camera.CameraController.CameraPosition = new Point3D(-5.981, 2.305, -8.024);
            uc6.camera.CameraController.CameraLookDirection = new Vector3D(5.981, -2.305, 8.024);
            panel1.Controls.Add(voltar6);
            voltar6.Visible = true;
            voltar6.BringToFront();
        }

        private void sobreOSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Sobre S = new Sobre();
            S.Show();
        }

        private void sobreOWiiMoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            sobre_nintendo1 S = new sobre_nintendo1();
            S.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(PlParalelo_IMG
                );
            PlParalelo_IMG.BringToFront();
            PlParalelo_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Planos_Paralelos);
            BTN_Planos_Paralelos.Visible = true;
            BTN_Planos_Paralelos.BringToFront();
            Planos_Retas PR = new Planos_Retas();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = PR;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
        }

        private void áreasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void voltar2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Prisma_IMG_Geral
                );
            Prisma_IMG_Geral.BringToFront();
            Prisma_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Volume);
            BTN_Volume.Visible = true;
            BTN_Volume.BringToFront();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Piramide_IMG_Geral
                );
            Piramide_IMG_Geral.BringToFront();
            Piramide_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Apotema);
            BTN_Apotema.Visible = true;
            BTN_Apotema.BringToFront();
        }

        private void voltar4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Piramide_IMG_apotema
                );
            Piramide_IMG_apotema.BringToFront();
            Piramide_IMG_apotema.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Piramide_AreaLateral);
            BTN_Piramide_AreaLateral.Visible = true;
            BTN_Piramide_AreaLateral.BringToFront();
            panel1.Controls.Add(voltar3);
            voltar3.Visible = true;
            voltar3.BringToFront();

        }

        private void voltar5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Piramide_IMG_AreaLateral
                );
            Piramide_IMG_AreaLateral.BringToFront();
            Piramide_IMG_AreaLateral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Piramide_AreaTotal);
            BTN_Piramide_AreaTotal.Visible = true;
            BTN_Piramide_AreaTotal.BringToFront();
            panel1.Controls.Add(voltar4);
            voltar4.Visible = true;
            voltar4.BringToFront();
        }

        private void voltar6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Piramide_IMG_AreaTotal
                );
            Piramide_IMG_AreaTotal.BringToFront();
            Piramide_IMG_AreaTotal.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Piramide_Volume);
            BTN_Piramide_Volume.Visible = true;
            BTN_Piramide_Volume.BringToFront();
            Geratriz_Piramide GP = new Geratriz_Piramide();
            ElementHost hostGP = new ElementHost();
            hostGP.Dock = DockStyle.Fill;
            hostGP.Child = GP;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostGP);
            panel1.Controls.Add(voltar5);
            voltar5.Visible = true;
            voltar5.BringToFront();
            GP.camera.CameraController.CameraUpDirection = new Vector3D(-3.550, 6.047, -5.082);
            GP.camera.CameraController.CameraPosition = new Point3D(-5.981, 2.305, -8.024);
            GP.camera.CameraController.CameraLookDirection = new Vector3D(5.981, -2.305, 8.024);
        }

        private void voltar7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Paralelepipedo_IMG_Geral
                );
            Paralelepipedo_IMG_Geral.BringToFront();
            Paralelepipedo_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Paralelepipedo_Diagonal);
            BTN_Paralelepipedo_Diagonal.Visible = true;
            BTN_Paralelepipedo_Diagonal.BringToFront();
        }

        private void voltar8_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Paralelepipedo_IMG_Diagonal
                );
            Paralelepipedo_IMG_Diagonal.BringToFront();
            Paralelepipedo_IMG_Diagonal.Visible = true;
            panel2.Controls.Add(label2);

            Diagonal_caixa DC = new Diagonal_caixa();
            ElementHost hostDC = new ElementHost();
            hostDC.Dock = DockStyle.Fill;
            hostDC.Child = DC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostDC);
            panel1.Controls.Add(BTN_ParalelepipedoArea);
            BTN_ParalelepipedoArea.Visible = true;
            BTN_ParalelepipedoArea.BringToFront();
            panel1.Controls.Add(voltar7);
            voltar7.Visible = true;
            voltar7.BringToFront();
        }

        private void voltar9_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Paralelepipedo_IMG_Area
                );
            Paralelepipedo_IMG_Area.BringToFront();
            Paralelepipedo_IMG_Area.Visible = true;
            panel2.Controls.Add(label2);

            Paralelepipedo_Area PA = new Paralelepipedo_Area();
            ElementHost hostPA = new ElementHost();
            hostPA.Dock = DockStyle.Fill;
            hostPA.Child = PA;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostPA);
            panel1.Controls.Add(voltar8);
            voltar8.Visible = true;
            voltar8.BringToFront();
            panel1.Controls.Add(BTN_Paralelepipedo_IMG_Volume);
            BTN_Paralelepipedo_IMG_Volume.Visible = true;
            BTN_Paralelepipedo_IMG_Volume.BringToFront();
        }

        private void voltar10_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cubo_IMG_Geral
                );
            Cubo_IMG_Geral.BringToFront();
            Cubo_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Diagonal);
            BTN_Diagonal.Visible = true;
            BTN_Diagonal.BringToFront();
        }

        private void voltar11_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Diagonal_IMG
                );
            Diagonal_IMG.BringToFront();
            Diagonal_IMG.Visible = true;
            panel2.Controls.Add(label2);

            Cubo_Diagonal CD = new Cubo_Diagonal();
            ElementHost hostCD = new ElementHost();
            hostCD.Dock = DockStyle.Fill;
            hostCD.Child = CD;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostCD);
            groupBox1.Visible = true;



            CD.camera.CameraController.CameraUpDirection = new Vector3D(-0.622, 0.023, 0.783);
            CD.camera.CameraController.CameraPosition = new Point3D(-11.935, 0.443, 2.675);

            CD.camera.CameraController.CameraLookDirection = new Vector3D(11.935, -0.443, -2.675);
            panel1.Controls.Add(voltar10);
            voltar10.Visible = true;
            voltar10.BringToFront();
            panel1.Controls.Add(BTN_Cubo_AreaTotal);
            BTN_Cubo_AreaTotal.Visible = true;
            BTN_Cubo_AreaTotal.BringToFront();
        }

        private void áreaDoCuboToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void voltar12_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cubo_AreaTotal_IMG
                );
            Cubo_AreaTotal_IMG.BringToFront();
            Cubo_AreaTotal_IMG.Visible = true;
            panel2.Controls.Add(label2);

            AreaLateral_Cubo AL = new AreaLateral_Cubo();
            ElementHost hostAL1 = new ElementHost();
            hostAL1.Dock = DockStyle.Fill;
            hostAL1.Child = AL;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostAL1);
            panel1.Controls.Add(voltar11);
            voltar11.Visible = true;
            voltar11.BringToFront();
            panel1.Controls.Add(BTN_Cubo_Volume);
            BTN_Cubo_Volume.Visible = true;
            BTN_Cubo_Volume.BringToFront();
        }

        private void voltar13_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cubo_AreaLateral
                );
            Cubo_AreaLateral.BringToFront();
            Cubo_AreaLateral.Visible = true;
            panel2.Controls.Add(label2);

            AreaTotal_Cubo AT = new AreaTotal_Cubo();
            ElementHost hostAT1 = new ElementHost();
            hostAT1.Dock = DockStyle.Fill;
            hostAT1.Child = AT;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostAT1);
            panel1.Controls.Add(voltar12);
            voltar12.Visible = true;
            voltar12.BringToFront();
            panel1.Controls.Add(BTN_Cubo_Volume);
            BTN_Cubo_Volume.Visible = true;
            BTN_Cubo_Volume.BringToFront();
        }

        private void voltar14_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Poliedro_IMG
                );
            Poliedro_IMG.BringToFront();
            Poliedro_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Euler);
            BTN_Euler.Visible = true;
            BTN_Euler.BringToFront();
        }

        private void voltar15_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Euler_IMG
                );
            Euler_IMG.BringToFront();
            Euler_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Octaedro);
            BTN_Octaedro.Visible = true;
            BTN_Octaedro.BringToFront();
            panel1.Controls.Add(voltar14);
            voltar14.Visible = true;
            voltar14.BringToFront();
        }

        private void voltar16_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Octaedro_IMG
                );
            Octaedro_IMG.BringToFront();
            Octaedro_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Icosaedro);
            BTN_Icosaedro.Visible = true;
            BTN_Icosaedro.BringToFront();
            Icosaedro I = new Icosaedro();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = I;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
            panel1.Controls.Add(voltar15);
            voltar15.Visible = true;
            voltar15.BringToFront();
        }

        private void voltar17_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Isosaedro_IMG
                );
            Isosaedro_IMG.BringToFront();
            Isosaedro_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Dodecaedro);
            BTN_Dodecaedro.Visible = true;
            BTN_Dodecaedro.BringToFront();
            Icosaedro1 I = new Icosaedro1();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = I;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
            panel1.Controls.Add(voltar16);
            voltar16.Visible = true;
            voltar16.BringToFront();
        }

        private void voltar18_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Dodecaedro_IMG
                );
            Dodecaedro_IMG.BringToFront();
            Dodecaedro_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Tetraedro);
            BTN_Tetraedro.Visible = true;
            BTN_Tetraedro.BringToFront();
            Dodecaedro D = new Dodecaedro();
            ElementHost hostQA = new ElementHost();
            hostQA.Dock = DockStyle.Fill;
            hostQA.Child = D;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostQA);
            panel1.Controls.Add(voltar17);
            voltar17.Visible = true;
            voltar17.BringToFront();
        }

        private void voltar19_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cilindro_IMG_Geral);
            Cilindro_IMG_Geral.BringToFront();
            Cilindro_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Cilindro_Geral);
            BTN_Cilindro_Geral.Visible = true;
            BTN_Cilindro_Geral.BringToFront();
        }

        private void voltar20_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cilindro_IMG_Volume);
            Cilindro_IMG_Volume.BringToFront();
            Cilindro_IMG_Volume.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Cilindro_AreaLateral);
            BTN_Cilindro_AreaLateral.Visible = true;
            BTN_Cilindro_AreaLateral.BringToFront();
            panel1.Controls.Add(voltar19);
            voltar19.Visible = true;
            voltar19.BringToFront();
            UserControl4 uc4 = new UserControl4();
            ElementHost host4 = new ElementHost();
            host4.Dock = DockStyle.Fill;
            host4.Child = uc4;

            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host4);
        }

        private void voltar21_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cilindro_IMG_Volume);
            Cilindro_IMG_Volume.BringToFront();
            Cilindro_IMG_Volume.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Cilindro_AreaLateral);
            BTN_Cilindro_AreaLateral.Visible = true;
            BTN_Cilindro_AreaLateral.BringToFront();
            panel1.Controls.Add(voltar19);
            voltar19.Visible = true;
            voltar19.BringToFront();
            UserControl4 uc4 = new UserControl4();
            ElementHost host4 = new ElementHost();
            host4.Dock = DockStyle.Fill;
            host4.Child = uc4;

            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host4);
        }

        private void voltar22_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cilindro_IMG_AreaLateral);
            Cilindro_IMG_AreaLateral.BringToFront();
            Cilindro_IMG_AreaLateral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Cilindro_AreaTotal);
            BTN_Cilindro_AreaTotal.Visible = true;
            BTN_Cilindro_AreaTotal.BringToFront();
            AreaLateralCilindro ALC = new AreaLateralCilindro();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);
            panel1.Controls.Add(voltar21);
            voltar21.Visible = true;
            voltar21.BringToFront();
        }

        private void voltar23_Click(object sender, EventArgs e)
        {

        }

        private void voltar24_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Cone_IMG);
            Cone_IMG.BringToFront();
            Cone_IMG.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(btn_Cone_Geral);
            btn_Cone_Geral.Visible = true;
            btn_Cone_Geral.BringToFront();

        }

        private void voltar25_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            btn_Cone_Geral.Visible = false;
            panel1.Controls.Add(Cone_IMG_Volume);
            panel1.Controls.Add(BTN_Cone_Volume);
            Cone_IMG_Volume.Visible = true;
            Cone_IMG_Volume.BringToFront();

            BTN_Cone_Volume.Visible = true;
            BTN_Cone_Volume.BringToFront();

            panel1.Controls.Add(voltar24);
            voltar24.Visible = true;
            voltar24.BringToFront();
            UserControl2 uc4 = new UserControl2();
            ElementHost host4 = new ElementHost();
            host4.Dock = DockStyle.Fill;
            host4.Child = uc4;

            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host4);
        }

        private void voltar26_Click(object sender, EventArgs e)
        {
            AreaLateralCone uc4 = new AreaLateralCone();
            ElementHost host4 = new ElementHost();
            host4.Dock = DockStyle.Fill;
            host4.Child = uc4;

            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(host4);
            panel1.Controls.Clear();
            BTN_Cone_Volume.Visible = false;
            panel1.Controls.Add(Cone_IMG_Geratriz);
            Cone_IMG_Geratriz.Visible = true;
            panel1.Controls.Add(BTN_Cone_AreaLateral);
            BTN_Cone_AreaLateral.Visible = true;
            BTN_Cone_AreaLateral.BringToFront();
            panel1.Controls.Add(voltar25);
            voltar25.Visible = true;
            voltar25.BringToFront();
        }

        private void voltar27_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(Cone_IMG_AreaLateral);
            Cone_IMG_AreaLateral.Visible = true;
            Cone_IMG_AreaLateral.BringToFront();
            panel1.Controls.Add(BTN_Cone_AreaTotal);
            BTN_Cone_AreaTotal.Visible = true;
            BTN_Cone_AreaTotal.BringToFront();
            panel1.Controls.Add(voltar26);
            voltar26.Visible = true;
            voltar26.BringToFront();
        }

        private void voltar28_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Esfera_IMG_Geral);
            Esfera_IMG_Geral.BringToFront();
            Esfera_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Esfera_Geral);
            BTN_Esfera_Geral.Visible = true;
            BTN_Esfera_Geral.BringToFront();
        }

        private void voltar29_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Esfera_IMG_AreaSuperficie
                );
            Esfera_IMG_AreaSuperficie.BringToFront();
            Esfera_IMG_AreaSuperficie.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Esfera_AreaSuperficie);
            BTN_Esfera_AreaSuperficie.Visible = true;
            BTN_Esfera_AreaSuperficie.BringToFront();
            AreaDeSuperficie_Esfera ALC = new AreaDeSuperficie_Esfera();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);
            panel1.Controls.Add(voltar28);
            voltar28.Visible = true;
            voltar28.BringToFront();
        }

        private void voltar30_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(Esfera_IMG_Volume)
                ;
            Esfera_IMG_Volume.BringToFront();
            Esfera_IMG_Volume.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_Esfera_Volume);
            BTN_Esfera_Volume.Visible = true;
            BTN_Esfera_Volume.BringToFront();
            UserControl1 ALC = new UserControl1();
            ElementHost hostLC = new ElementHost();
            hostLC.Dock = DockStyle.Fill;
            hostLC.Child = ALC;
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hostLC);
            panel1.Controls.Add(voltar29);
            voltar29.Visible = true;
            voltar29.BringToFront();
        }

        private void voltar31_Click(object sender, EventArgs e)
        {

        }

        private void voltar31_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.Controls.Add(FIG_IMG_Geral
                );
            FIG_IMG_Geral.BringToFront();
            FIG_IMG_Geral.Visible = true;
            panel2.Controls.Add(label2);
            panel1.Controls.Add(BTN_AreaQuadrado);
            BTN_AreaQuadrado.Visible = true;
            BTN_AreaQuadrado.BringToFront();
            panel1.Controls.Add(BTN_AreaRetangulo);
            BTN_AreaRetangulo.Visible = true;
            BTN_AreaRetangulo.BringToFront();
            panel1.Controls.Add(BTN_AreaTriangulo);
            BTN_AreaTriangulo.Visible = true;
            BTN_AreaTriangulo.BringToFront();
        }

        private void ajudaDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var processo = new System.Diagnostics.ProcessStartInfo() { FileName = "manual.chm" };
                var p = System.Diagnostics.Process.Start(processo);
            }
            catch (Exception ex)
            {
                MSG26 M = new MSG26();
                M.Show();
            }
        }




    }
}
namespace SisPadoca
{
    partial class Frmprodutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            LblNcm = new Label();
            TxbNcm = new TextBox();
            BtnNovo = new Button();
            ImgLista = new ImageList(components);
            CmbUnidade = new ComboBox();
            PtxImagem = new PictureBox();
            TxbDescricao = new TextBox();
            LblDescricao = new Label();
            TxbCodigoBarras = new TextBox();
            LblCodigoBarras = new Label();
            LblUnidade = new Label();
            LblLote = new Label();
            TxbLote = new TextBox();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnLimpar = new Button();
            BtnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)PtxImagem).BeginInit();
            SuspendLayout();
            // 
            // LblNcm
            // 
            LblNcm.AutoSize = true;
            LblNcm.Location = new Point(290, 43);
            LblNcm.Name = "LblNcm";
            LblNcm.Size = new Size(52, 25);
            LblNcm.TabIndex = 0;
            LblNcm.Text = "NCM";
            // 
            // TxbNcm
            // 
            TxbNcm.Location = new Point(290, 71);
            TxbNcm.Name = "TxbNcm";
            TxbNcm.Size = new Size(182, 31);
            TxbNcm.TabIndex = 1;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(62, 321);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(149, 69);
            BtnNovo.TabIndex = 2;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // ImgLista
            // 
            ImgLista.ColorDepth = ColorDepth.Depth32Bit;
            ImgLista.ImageSize = new Size(16, 16);
            ImgLista.TransparentColor = Color.Transparent;
            // 
            // CmbUnidade
            // 
            CmbUnidade.FormattingEnabled = true;
            CmbUnidade.Items.AddRange(new object[] { "Unitario", "Kilo", "Idoso" });
            CmbUnidade.Location = new Point(751, 142);
            CmbUnidade.Name = "CmbUnidade";
            CmbUnidade.Size = new Size(182, 33);
            CmbUnidade.TabIndex = 3;
            CmbUnidade.SelectedIndexChanged += CmbUnidade_SelectedIndexChanged;
            // 
            // PtxImagem
            // 
            PtxImagem.Location = new Point(62, 43);
            PtxImagem.Name = "PtxImagem";
            PtxImagem.Size = new Size(197, 204);
            PtxImagem.TabIndex = 4;
            PtxImagem.TabStop = false;
            // 
            // TxbDescricao
            // 
            TxbDescricao.Location = new Point(290, 142);
            TxbDescricao.Name = "TxbDescricao";
            TxbDescricao.Size = new Size(382, 31);
            TxbDescricao.TabIndex = 6;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(290, 114);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(88, 25);
            LblDescricao.TabIndex = 5;
            LblDescricao.Text = "Descrição";
            // 
            // TxbCodigoBarras
            // 
            TxbCodigoBarras.Location = new Point(290, 216);
            TxbCodigoBarras.Name = "TxbCodigoBarras";
            TxbCodigoBarras.Size = new Size(382, 31);
            TxbCodigoBarras.TabIndex = 8;
            TxbCodigoBarras.TextChanged += textBox3_TextChanged;
            // 
            // LblCodigoBarras
            // 
            LblCodigoBarras.AutoSize = true;
            LblCodigoBarras.Location = new Point(290, 188);
            LblCodigoBarras.Name = "LblCodigoBarras";
            LblCodigoBarras.Size = new Size(149, 25);
            LblCodigoBarras.TabIndex = 7;
            LblCodigoBarras.Text = "Código de Barras";
            // 
            // LblUnidade
            // 
            LblUnidade.AutoSize = true;
            LblUnidade.Location = new Point(751, 114);
            LblUnidade.Name = "LblUnidade";
            LblUnidade.Size = new Size(168, 25);
            LblUnidade.TabIndex = 9;
            LblUnidade.Text = "Unidade de Medida";
            // 
            // LblLote
            // 
            LblLote.AutoSize = true;
            LblLote.Location = new Point(751, 188);
            LblLote.Name = "LblLote";
            LblLote.Size = new Size(46, 25);
            LblLote.TabIndex = 10;
            LblLote.Text = "Lote";
            // 
            // TxbLote
            // 
            TxbLote.Location = new Point(751, 216);
            TxbLote.Name = "TxbLote";
            TxbLote.Size = new Size(182, 31);
            TxbLote.TabIndex = 11;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(248, 321);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(149, 69);
            BtnEditar.TabIndex = 12;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(426, 321);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(149, 69);
            BtnExcluir.TabIndex = 13;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(612, 321);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(149, 69);
            BtnLimpar.TabIndex = 14;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(784, 321);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(149, 69);
            BtnFechar.TabIndex = 15;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // Frmprodutos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 575);
            Controls.Add(BtnFechar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(TxbLote);
            Controls.Add(LblLote);
            Controls.Add(LblUnidade);
            Controls.Add(TxbCodigoBarras);
            Controls.Add(LblCodigoBarras);
            Controls.Add(TxbDescricao);
            Controls.Add(LblDescricao);
            Controls.Add(PtxImagem);
            Controls.Add(CmbUnidade);
            Controls.Add(BtnNovo);
            Controls.Add(TxbNcm);
            Controls.Add(LblNcm);
            Name = "Frmprodutos";
            Text = "Frmprodutos";
            ((System.ComponentModel.ISupportInitialize)PtxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNcm;
        private TextBox TxbNcm;
        private Button BtnNovo;
        private ImageList ImgLista;
        private ComboBox CmbUnidade;
        private PictureBox PtxImagem;
        private TextBox TxbDescricao;
        private Label LblDescricao;
        private TextBox TxbCodigoBarras;
        private Label LblCodigoBarras;
        private Label LblUnidade;
        private Label LblLote;
        private TextBox TxbLote;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Button BtnLimpar;
        private Button BtnFechar;
    }
}
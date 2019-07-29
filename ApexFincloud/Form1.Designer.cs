namespace ApexFincloud
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._addOrderBtn = new System.Windows.Forms.Button();
            this._logOnBtn = new System.Windows.Forms.Button();
            this._emailTxt = new System.Windows.Forms.TextBox();
            this._emailLbl = new System.Windows.Forms.Label();
            this._pwdTxt = new System.Windows.Forms.TextBox();
            this._pwdLbl = new System.Windows.Forms.Label();
            this._futureSellBtn = new System.Windows.Forms.Button();
            this._futureBuyBtn = new System.Windows.Forms.Button();
            this._futureDayTradeChk = new System.Windows.Forms.CheckBox();
            this._futureBuySellGrp = new System.Windows.Forms.GroupBox();
            this._futureSellRdo = new System.Windows.Forms.RadioButton();
            this._futureBuyRdo = new System.Windows.Forms.RadioButton();
            this._futureTradeTypeGrp = new System.Windows.Forms.GroupBox();
            this._futureFokRdo = new System.Windows.Forms.RadioButton();
            this._futureIocRdo = new System.Windows.Forms.RadioButton();
            this._futureRodRdo = new System.Windows.Forms.RadioButton();
            this._futureVolumeTxt = new System.Windows.Forms.TextBox();
            this._futurePriceTxt = new System.Windows.Forms.TextBox();
            this._futurePriceLbl = new System.Windows.Forms.Label();
            this._futureVolumeLbl = new System.Windows.Forms.Label();
            this._futureOrderGrp = new System.Windows.Forms.GroupBox();
            this._futureErrorLogBtn = new System.Windows.Forms.Button();
            this._futureDealLogBtn = new System.Windows.Forms.Button();
            this._futureOrderListBtn = new System.Windows.Forms.Button();
            this._cancelOrderBtn = new System.Windows.Forms.Button();
            this._futureOrderCodeTxt = new System.Windows.Forms.TextBox();
            this._gmridListCmb = new System.Windows.Forms.ComboBox();
            this._stockOrderGrp = new System.Windows.Forms.GroupBox();
            this._stockCodeTxt = new System.Windows.Forms.TextBox();
            this._stockCodeLbl = new System.Windows.Forms.Label();
            this._stockPriceTxt = new System.Windows.Forms.TextBox();
            this._stockPriceLbl = new System.Windows.Forms.Label();
            this._stockVolTxt = new System.Windows.Forms.TextBox();
            this._stockVolLbl = new System.Windows.Forms.Label();
            this._stockOrderTypeGrp = new System.Windows.Forms.GroupBox();
            this._stockBuyRdo = new System.Windows.Forms.RadioButton();
            this._stockSellRdo = new System.Windows.Forms.RadioButton();
            this._stockMarginBuyRdo = new System.Windows.Forms.RadioButton();
            this._stockRentBuyRdo = new System.Windows.Forms.RadioButton();
            this._stockMarginSellRdo = new System.Windows.Forms.RadioButton();
            this._stockRentSellRdo = new System.Windows.Forms.RadioButton();
            this._sendStockOrderBtn = new System.Windows.Forms.Button();
            this._futureBuySellGrp.SuspendLayout();
            this._futureTradeTypeGrp.SuspendLayout();
            this._futureOrderGrp.SuspendLayout();
            this._stockOrderGrp.SuspendLayout();
            this._stockOrderTypeGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // _addOrderBtn
            // 
            this._addOrderBtn.Location = new System.Drawing.Point(594, 58);
            this._addOrderBtn.Name = "_addOrderBtn";
            this._addOrderBtn.Size = new System.Drawing.Size(75, 23);
            this._addOrderBtn.TabIndex = 0;
            this._addOrderBtn.Text = "AddOrder";
            this._addOrderBtn.UseVisualStyleBackColor = true;
            this._addOrderBtn.Click += new System.EventHandler(this._addOrderBtn_Click);
            // 
            // _logOnBtn
            // 
            this._logOnBtn.Location = new System.Drawing.Point(222, 39);
            this._logOnBtn.Name = "_logOnBtn";
            this._logOnBtn.Size = new System.Drawing.Size(75, 23);
            this._logOnBtn.TabIndex = 1;
            this._logOnBtn.Text = "登入";
            this._logOnBtn.UseVisualStyleBackColor = true;
            this._logOnBtn.Click += new System.EventHandler(this._logOnBtn_Click);
            // 
            // _emailTxt
            // 
            this._emailTxt.Location = new System.Drawing.Point(116, 11);
            this._emailTxt.Name = "_emailTxt";
            this._emailTxt.Size = new System.Drawing.Size(100, 22);
            this._emailTxt.TabIndex = 2;
            // 
            // _emailLbl
            // 
            this._emailLbl.Location = new System.Drawing.Point(10, 9);
            this._emailLbl.Name = "_emailLbl";
            this._emailLbl.Size = new System.Drawing.Size(100, 23);
            this._emailLbl.TabIndex = 3;
            this._emailLbl.Text = "Email";
            this._emailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _pwdTxt
            // 
            this._pwdTxt.Location = new System.Drawing.Point(116, 39);
            this._pwdTxt.Name = "_pwdTxt";
            this._pwdTxt.PasswordChar = '#';
            this._pwdTxt.Size = new System.Drawing.Size(100, 22);
            this._pwdTxt.TabIndex = 4;
            // 
            // _pwdLbl
            // 
            this._pwdLbl.Location = new System.Drawing.Point(12, 37);
            this._pwdLbl.Name = "_pwdLbl";
            this._pwdLbl.Size = new System.Drawing.Size(100, 23);
            this._pwdLbl.TabIndex = 5;
            this._pwdLbl.Text = "Password";
            this._pwdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _futureSellBtn
            // 
            this._futureSellBtn.Location = new System.Drawing.Point(569, 17);
            this._futureSellBtn.Name = "_futureSellBtn";
            this._futureSellBtn.Size = new System.Drawing.Size(75, 23);
            this._futureSellBtn.TabIndex = 6;
            this._futureSellBtn.Text = "Sell";
            this._futureSellBtn.UseVisualStyleBackColor = true;
            this._futureSellBtn.Click += new System.EventHandler(this._futureSellBtn_Click);
            // 
            // _futureBuyBtn
            // 
            this._futureBuyBtn.Location = new System.Drawing.Point(488, 17);
            this._futureBuyBtn.Name = "_futureBuyBtn";
            this._futureBuyBtn.Size = new System.Drawing.Size(75, 23);
            this._futureBuyBtn.TabIndex = 7;
            this._futureBuyBtn.Text = "Buy";
            this._futureBuyBtn.UseVisualStyleBackColor = true;
            this._futureBuyBtn.Click += new System.EventHandler(this._futureBuyBtn_Click);
            // 
            // _futureDayTradeChk
            // 
            this._futureDayTradeChk.AutoSize = true;
            this._futureDayTradeChk.Location = new System.Drawing.Point(14, 21);
            this._futureDayTradeChk.Name = "_futureDayTradeChk";
            this._futureDayTradeChk.Size = new System.Drawing.Size(60, 16);
            this._futureDayTradeChk.TabIndex = 8;
            this._futureDayTradeChk.Text = "當冲單";
            this._futureDayTradeChk.UseVisualStyleBackColor = true;
            // 
            // _futureBuySellGrp
            // 
            this._futureBuySellGrp.Controls.Add(this._futureSellRdo);
            this._futureBuySellGrp.Controls.Add(this._futureBuyRdo);
            this._futureBuySellGrp.Location = new System.Drawing.Point(14, 43);
            this._futureBuySellGrp.Name = "_futureBuySellGrp";
            this._futureBuySellGrp.Size = new System.Drawing.Size(100, 49);
            this._futureBuySellGrp.TabIndex = 9;
            this._futureBuySellGrp.TabStop = false;
            this._futureBuySellGrp.Text = "買賣";
            // 
            // _futureSellRdo
            // 
            this._futureSellRdo.AutoSize = true;
            this._futureSellRdo.Location = new System.Drawing.Point(57, 21);
            this._futureSellRdo.Name = "_futureSellRdo";
            this._futureSellRdo.Size = new System.Drawing.Size(35, 16);
            this._futureSellRdo.TabIndex = 1;
            this._futureSellRdo.Text = "賣";
            this._futureSellRdo.UseVisualStyleBackColor = true;
            // 
            // _futureBuyRdo
            // 
            this._futureBuyRdo.AutoSize = true;
            this._futureBuyRdo.Checked = true;
            this._futureBuyRdo.Location = new System.Drawing.Point(16, 21);
            this._futureBuyRdo.Name = "_futureBuyRdo";
            this._futureBuyRdo.Size = new System.Drawing.Size(35, 16);
            this._futureBuyRdo.TabIndex = 0;
            this._futureBuyRdo.TabStop = true;
            this._futureBuyRdo.Text = "買";
            this._futureBuyRdo.UseVisualStyleBackColor = true;
            // 
            // _futureTradeTypeGrp
            // 
            this._futureTradeTypeGrp.Controls.Add(this._futureFokRdo);
            this._futureTradeTypeGrp.Controls.Add(this._futureIocRdo);
            this._futureTradeTypeGrp.Controls.Add(this._futureRodRdo);
            this._futureTradeTypeGrp.Location = new System.Drawing.Point(120, 45);
            this._futureTradeTypeGrp.Name = "_futureTradeTypeGrp";
            this._futureTradeTypeGrp.Size = new System.Drawing.Size(168, 49);
            this._futureTradeTypeGrp.TabIndex = 10;
            this._futureTradeTypeGrp.TabStop = false;
            this._futureTradeTypeGrp.Text = "委託類型";
            // 
            // _futureFokRdo
            // 
            this._futureFokRdo.AutoSize = true;
            this._futureFokRdo.Location = new System.Drawing.Point(108, 21);
            this._futureFokRdo.Name = "_futureFokRdo";
            this._futureFokRdo.Size = new System.Drawing.Size(45, 16);
            this._futureFokRdo.TabIndex = 2;
            this._futureFokRdo.Text = "FOK";
            this._futureFokRdo.UseVisualStyleBackColor = true;
            // 
            // _futureIocRdo
            // 
            this._futureIocRdo.AutoSize = true;
            this._futureIocRdo.Location = new System.Drawing.Point(59, 21);
            this._futureIocRdo.Name = "_futureIocRdo";
            this._futureIocRdo.Size = new System.Drawing.Size(43, 16);
            this._futureIocRdo.TabIndex = 1;
            this._futureIocRdo.Text = "IOC";
            this._futureIocRdo.UseVisualStyleBackColor = true;
            // 
            // _futureRodRdo
            // 
            this._futureRodRdo.AutoSize = true;
            this._futureRodRdo.Checked = true;
            this._futureRodRdo.Location = new System.Drawing.Point(6, 21);
            this._futureRodRdo.Name = "_futureRodRdo";
            this._futureRodRdo.Size = new System.Drawing.Size(47, 16);
            this._futureRodRdo.TabIndex = 0;
            this._futureRodRdo.TabStop = true;
            this._futureRodRdo.Text = "ROD";
            this._futureRodRdo.UseVisualStyleBackColor = true;
            // 
            // _futureVolumeTxt
            // 
            this._futureVolumeTxt.Location = new System.Drawing.Point(488, 58);
            this._futureVolumeTxt.Name = "_futureVolumeTxt";
            this._futureVolumeTxt.Size = new System.Drawing.Size(100, 22);
            this._futureVolumeTxt.TabIndex = 11;
            this._futureVolumeTxt.Text = "1";
            this._futureVolumeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _futurePriceTxt
            // 
            this._futurePriceTxt.Location = new System.Drawing.Point(338, 58);
            this._futurePriceTxt.Name = "_futurePriceTxt";
            this._futurePriceTxt.Size = new System.Drawing.Size(100, 22);
            this._futurePriceTxt.TabIndex = 12;
            this._futurePriceTxt.Text = "0";
            this._futurePriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _futurePriceLbl
            // 
            this._futurePriceLbl.Location = new System.Drawing.Point(294, 61);
            this._futurePriceLbl.Name = "_futurePriceLbl";
            this._futurePriceLbl.Size = new System.Drawing.Size(38, 23);
            this._futurePriceLbl.TabIndex = 13;
            this._futurePriceLbl.Text = "價格";
            this._futurePriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _futureVolumeLbl
            // 
            this._futureVolumeLbl.Location = new System.Drawing.Point(444, 61);
            this._futureVolumeLbl.Name = "_futureVolumeLbl";
            this._futureVolumeLbl.Size = new System.Drawing.Size(38, 23);
            this._futureVolumeLbl.TabIndex = 14;
            this._futureVolumeLbl.Text = "數量";
            this._futureVolumeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _futureOrderGrp
            // 
            this._futureOrderGrp.Controls.Add(this._futureErrorLogBtn);
            this._futureOrderGrp.Controls.Add(this._futureDealLogBtn);
            this._futureOrderGrp.Controls.Add(this._futureOrderListBtn);
            this._futureOrderGrp.Controls.Add(this._cancelOrderBtn);
            this._futureOrderGrp.Controls.Add(this._futureOrderCodeTxt);
            this._futureOrderGrp.Controls.Add(this._futureDayTradeChk);
            this._futureOrderGrp.Controls.Add(this._futureSellBtn);
            this._futureOrderGrp.Controls.Add(this._futureBuyBtn);
            this._futureOrderGrp.Controls.Add(this._futureVolumeTxt);
            this._futureOrderGrp.Controls.Add(this._futureVolumeLbl);
            this._futureOrderGrp.Controls.Add(this._futureBuySellGrp);
            this._futureOrderGrp.Controls.Add(this._futurePriceTxt);
            this._futureOrderGrp.Controls.Add(this._futurePriceLbl);
            this._futureOrderGrp.Controls.Add(this._futureTradeTypeGrp);
            this._futureOrderGrp.Controls.Add(this._addOrderBtn);
            this._futureOrderGrp.Location = new System.Drawing.Point(14, 68);
            this._futureOrderGrp.Name = "_futureOrderGrp";
            this._futureOrderGrp.Size = new System.Drawing.Size(715, 143);
            this._futureOrderGrp.TabIndex = 15;
            this._futureOrderGrp.TabStop = false;
            this._futureOrderGrp.Text = "期貨下單夾";
            // 
            // _futureErrorLogBtn
            // 
            this._futureErrorLogBtn.Location = new System.Drawing.Point(183, 100);
            this._futureErrorLogBtn.Name = "_futureErrorLogBtn";
            this._futureErrorLogBtn.Size = new System.Drawing.Size(75, 23);
            this._futureErrorLogBtn.TabIndex = 19;
            this._futureErrorLogBtn.Text = "錯誤回報";
            this._futureErrorLogBtn.UseVisualStyleBackColor = true;
            this._futureErrorLogBtn.Click += new System.EventHandler(this._futureErrorLogBtn_Click);
            // 
            // _futureDealLogBtn
            // 
            this._futureDealLogBtn.Location = new System.Drawing.Point(102, 99);
            this._futureDealLogBtn.Name = "_futureDealLogBtn";
            this._futureDealLogBtn.Size = new System.Drawing.Size(75, 23);
            this._futureDealLogBtn.TabIndex = 18;
            this._futureDealLogBtn.Text = "成交回報";
            this._futureDealLogBtn.UseVisualStyleBackColor = true;
            this._futureDealLogBtn.Click += new System.EventHandler(this._futureDealLogBtn_Click);
            // 
            // _futureOrderListBtn
            // 
            this._futureOrderListBtn.Location = new System.Drawing.Point(14, 99);
            this._futureOrderListBtn.Name = "_futureOrderListBtn";
            this._futureOrderListBtn.Size = new System.Drawing.Size(75, 23);
            this._futureOrderListBtn.TabIndex = 17;
            this._futureOrderListBtn.Text = "委託回報";
            this._futureOrderListBtn.UseVisualStyleBackColor = true;
            this._futureOrderListBtn.Click += new System.EventHandler(this._futureOrderListBtn_Click);
            // 
            // _cancelOrderBtn
            // 
            this._cancelOrderBtn.Location = new System.Drawing.Point(407, 17);
            this._cancelOrderBtn.Name = "_cancelOrderBtn";
            this._cancelOrderBtn.Size = new System.Drawing.Size(75, 23);
            this._cancelOrderBtn.TabIndex = 16;
            this._cancelOrderBtn.Text = "CancelOrder";
            this._cancelOrderBtn.UseVisualStyleBackColor = true;
            this._cancelOrderBtn.Click += new System.EventHandler(this._cancelOrderBtn_Click);
            // 
            // _futureOrderCodeTxt
            // 
            this._futureOrderCodeTxt.Location = new System.Drawing.Point(301, 21);
            this._futureOrderCodeTxt.Name = "_futureOrderCodeTxt";
            this._futureOrderCodeTxt.Size = new System.Drawing.Size(100, 22);
            this._futureOrderCodeTxt.TabIndex = 15;
            // 
            // _gmridListCmb
            // 
            this._gmridListCmb.FormattingEnabled = true;
            this._gmridListCmb.Location = new System.Drawing.Point(310, 13);
            this._gmridListCmb.Name = "_gmridListCmb";
            this._gmridListCmb.Size = new System.Drawing.Size(267, 20);
            this._gmridListCmb.TabIndex = 16;
            // 
            // _stockOrderGrp
            // 
            this._stockOrderGrp.Controls.Add(this._sendStockOrderBtn);
            this._stockOrderGrp.Controls.Add(this._stockOrderTypeGrp);
            this._stockOrderGrp.Controls.Add(this._stockVolLbl);
            this._stockOrderGrp.Controls.Add(this._stockVolTxt);
            this._stockOrderGrp.Controls.Add(this._stockPriceLbl);
            this._stockOrderGrp.Controls.Add(this._stockPriceTxt);
            this._stockOrderGrp.Controls.Add(this._stockCodeLbl);
            this._stockOrderGrp.Controls.Add(this._stockCodeTxt);
            this._stockOrderGrp.Location = new System.Drawing.Point(14, 218);
            this._stockOrderGrp.Name = "_stockOrderGrp";
            this._stockOrderGrp.Size = new System.Drawing.Size(715, 120);
            this._stockOrderGrp.TabIndex = 17;
            this._stockOrderGrp.TabStop = false;
            this._stockOrderGrp.Text = "股票下單夾";
            // 
            // _stockCodeTxt
            // 
            this._stockCodeTxt.Location = new System.Drawing.Point(112, 18);
            this._stockCodeTxt.Name = "_stockCodeTxt";
            this._stockCodeTxt.Size = new System.Drawing.Size(100, 22);
            this._stockCodeTxt.TabIndex = 0;
            // 
            // _stockCodeLbl
            // 
            this._stockCodeLbl.Location = new System.Drawing.Point(6, 18);
            this._stockCodeLbl.Name = "_stockCodeLbl";
            this._stockCodeLbl.Size = new System.Drawing.Size(100, 23);
            this._stockCodeLbl.TabIndex = 1;
            this._stockCodeLbl.Text = "股票代碼";
            this._stockCodeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _stockPriceTxt
            // 
            this._stockPriceTxt.Location = new System.Drawing.Point(112, 53);
            this._stockPriceTxt.Name = "_stockPriceTxt";
            this._stockPriceTxt.Size = new System.Drawing.Size(100, 22);
            this._stockPriceTxt.TabIndex = 2;
            this._stockPriceTxt.Text = "0";
            // 
            // _stockPriceLbl
            // 
            this._stockPriceLbl.Location = new System.Drawing.Point(6, 51);
            this._stockPriceLbl.Name = "_stockPriceLbl";
            this._stockPriceLbl.Size = new System.Drawing.Size(100, 23);
            this._stockPriceLbl.TabIndex = 3;
            this._stockPriceLbl.Text = "價格";
            this._stockPriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _stockVolTxt
            // 
            this._stockVolTxt.Location = new System.Drawing.Point(112, 87);
            this._stockVolTxt.Name = "_stockVolTxt";
            this._stockVolTxt.Size = new System.Drawing.Size(100, 22);
            this._stockVolTxt.TabIndex = 4;
            this._stockVolTxt.Text = "1";
            // 
            // _stockVolLbl
            // 
            this._stockVolLbl.Location = new System.Drawing.Point(6, 86);
            this._stockVolLbl.Name = "_stockVolLbl";
            this._stockVolLbl.Size = new System.Drawing.Size(100, 23);
            this._stockVolLbl.TabIndex = 5;
            this._stockVolLbl.Text = "數量";
            this._stockVolLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _stockOrderTypeGrp
            // 
            this._stockOrderTypeGrp.Controls.Add(this._stockRentSellRdo);
            this._stockOrderTypeGrp.Controls.Add(this._stockMarginSellRdo);
            this._stockOrderTypeGrp.Controls.Add(this._stockRentBuyRdo);
            this._stockOrderTypeGrp.Controls.Add(this._stockMarginBuyRdo);
            this._stockOrderTypeGrp.Controls.Add(this._stockSellRdo);
            this._stockOrderTypeGrp.Controls.Add(this._stockBuyRdo);
            this._stockOrderTypeGrp.Location = new System.Drawing.Point(228, 14);
            this._stockOrderTypeGrp.Name = "_stockOrderTypeGrp";
            this._stockOrderTypeGrp.Size = new System.Drawing.Size(348, 96);
            this._stockOrderTypeGrp.TabIndex = 6;
            this._stockOrderTypeGrp.TabStop = false;
            this._stockOrderTypeGrp.Text = "買賣方式";
            // 
            // _stockBuyRdo
            // 
            this._stockBuyRdo.AutoSize = true;
            this._stockBuyRdo.Location = new System.Drawing.Point(19, 21);
            this._stockBuyRdo.Name = "_stockBuyRdo";
            this._stockBuyRdo.Size = new System.Drawing.Size(71, 16);
            this._stockBuyRdo.TabIndex = 0;
            this._stockBuyRdo.TabStop = true;
            this._stockBuyRdo.Text = "現貨買進";
            this._stockBuyRdo.UseVisualStyleBackColor = true;
            // 
            // _stockSellRdo
            // 
            this._stockSellRdo.AutoSize = true;
            this._stockSellRdo.Location = new System.Drawing.Point(19, 57);
            this._stockSellRdo.Name = "_stockSellRdo";
            this._stockSellRdo.Size = new System.Drawing.Size(71, 16);
            this._stockSellRdo.TabIndex = 1;
            this._stockSellRdo.TabStop = true;
            this._stockSellRdo.Text = "現貨賣出";
            this._stockSellRdo.UseVisualStyleBackColor = true;
            // 
            // _stockMarginBuyRdo
            // 
            this._stockMarginBuyRdo.AutoSize = true;
            this._stockMarginBuyRdo.Location = new System.Drawing.Point(139, 22);
            this._stockMarginBuyRdo.Name = "_stockMarginBuyRdo";
            this._stockMarginBuyRdo.Size = new System.Drawing.Size(71, 16);
            this._stockMarginBuyRdo.TabIndex = 2;
            this._stockMarginBuyRdo.TabStop = true;
            this._stockMarginBuyRdo.Text = "融資買進";
            this._stockMarginBuyRdo.UseVisualStyleBackColor = true;
            // 
            // _stockRentBuyRdo
            // 
            this._stockRentBuyRdo.AutoSize = true;
            this._stockRentBuyRdo.Location = new System.Drawing.Point(139, 57);
            this._stockRentBuyRdo.Name = "_stockRentBuyRdo";
            this._stockRentBuyRdo.Size = new System.Drawing.Size(71, 16);
            this._stockRentBuyRdo.TabIndex = 3;
            this._stockRentBuyRdo.TabStop = true;
            this._stockRentBuyRdo.Text = "融資賣出";
            this._stockRentBuyRdo.UseVisualStyleBackColor = true;
            // 
            // _stockMarginSellRdo
            // 
            this._stockMarginSellRdo.AutoSize = true;
            this._stockMarginSellRdo.Location = new System.Drawing.Point(250, 21);
            this._stockMarginSellRdo.Name = "_stockMarginSellRdo";
            this._stockMarginSellRdo.Size = new System.Drawing.Size(71, 16);
            this._stockMarginSellRdo.TabIndex = 4;
            this._stockMarginSellRdo.TabStop = true;
            this._stockMarginSellRdo.Text = "融券賣出";
            this._stockMarginSellRdo.UseVisualStyleBackColor = true;
            // 
            // _stockRentSellRdo
            // 
            this._stockRentSellRdo.AutoSize = true;
            this._stockRentSellRdo.Location = new System.Drawing.Point(250, 56);
            this._stockRentSellRdo.Name = "_stockRentSellRdo";
            this._stockRentSellRdo.Size = new System.Drawing.Size(71, 16);
            this._stockRentSellRdo.TabIndex = 5;
            this._stockRentSellRdo.TabStop = true;
            this._stockRentSellRdo.Text = "融券買進";
            this._stockRentSellRdo.UseVisualStyleBackColor = true;
            // 
            // _sendStockOrderBtn
            // 
            this._sendStockOrderBtn.Location = new System.Drawing.Point(594, 85);
            this._sendStockOrderBtn.Name = "_sendStockOrderBtn";
            this._sendStockOrderBtn.Size = new System.Drawing.Size(75, 23);
            this._sendStockOrderBtn.TabIndex = 7;
            this._sendStockOrderBtn.Text = "送單";
            this._sendStockOrderBtn.UseVisualStyleBackColor = true;
            this._sendStockOrderBtn.Click += new System.EventHandler(this._sendStockOrderBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 405);
            this.Controls.Add(this._stockOrderGrp);
            this.Controls.Add(this._gmridListCmb);
            this.Controls.Add(this._futureOrderGrp);
            this.Controls.Add(this._pwdLbl);
            this.Controls.Add(this._pwdTxt);
            this.Controls.Add(this._emailLbl);
            this.Controls.Add(this._emailTxt);
            this.Controls.Add(this._logOnBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this._futureBuySellGrp.ResumeLayout(false);
            this._futureBuySellGrp.PerformLayout();
            this._futureTradeTypeGrp.ResumeLayout(false);
            this._futureTradeTypeGrp.PerformLayout();
            this._futureOrderGrp.ResumeLayout(false);
            this._futureOrderGrp.PerformLayout();
            this._stockOrderGrp.ResumeLayout(false);
            this._stockOrderGrp.PerformLayout();
            this._stockOrderTypeGrp.ResumeLayout(false);
            this._stockOrderTypeGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _addOrderBtn;
        private System.Windows.Forms.Button _logOnBtn;
        private System.Windows.Forms.TextBox _emailTxt;
        private System.Windows.Forms.Label _emailLbl;
        private System.Windows.Forms.TextBox _pwdTxt;
        private System.Windows.Forms.Label _pwdLbl;
        private System.Windows.Forms.Button _futureSellBtn;
        private System.Windows.Forms.Button _futureBuyBtn;
        private System.Windows.Forms.CheckBox _futureDayTradeChk;
        private System.Windows.Forms.GroupBox _futureBuySellGrp;
        private System.Windows.Forms.RadioButton _futureSellRdo;
        private System.Windows.Forms.RadioButton _futureBuyRdo;
        private System.Windows.Forms.GroupBox _futureTradeTypeGrp;
        private System.Windows.Forms.RadioButton _futureFokRdo;
        private System.Windows.Forms.RadioButton _futureIocRdo;
        private System.Windows.Forms.RadioButton _futureRodRdo;
        private System.Windows.Forms.TextBox _futureVolumeTxt;
        private System.Windows.Forms.TextBox _futurePriceTxt;
        private System.Windows.Forms.Label _futurePriceLbl;
        private System.Windows.Forms.Label _futureVolumeLbl;
        private System.Windows.Forms.GroupBox _futureOrderGrp;
        private System.Windows.Forms.Button _cancelOrderBtn;
        private System.Windows.Forms.TextBox _futureOrderCodeTxt;
        private System.Windows.Forms.Button _futureOrderListBtn;
        private System.Windows.Forms.Button _futureDealLogBtn;
        private System.Windows.Forms.Button _futureErrorLogBtn;
        private System.Windows.Forms.ComboBox _gmridListCmb;
        private System.Windows.Forms.GroupBox _stockOrderGrp;
        private System.Windows.Forms.Label _stockVolLbl;
        private System.Windows.Forms.TextBox _stockVolTxt;
        private System.Windows.Forms.Label _stockPriceLbl;
        private System.Windows.Forms.TextBox _stockPriceTxt;
        private System.Windows.Forms.Label _stockCodeLbl;
        private System.Windows.Forms.TextBox _stockCodeTxt;
        private System.Windows.Forms.GroupBox _stockOrderTypeGrp;
        private System.Windows.Forms.RadioButton _stockRentSellRdo;
        private System.Windows.Forms.RadioButton _stockMarginSellRdo;
        private System.Windows.Forms.RadioButton _stockRentBuyRdo;
        private System.Windows.Forms.RadioButton _stockMarginBuyRdo;
        private System.Windows.Forms.RadioButton _stockSellRdo;
        private System.Windows.Forms.RadioButton _stockBuyRdo;
        private System.Windows.Forms.Button _sendStockOrderBtn;
    }
}


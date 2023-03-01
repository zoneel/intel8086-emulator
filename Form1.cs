using System.Text.RegularExpressions;

namespace Intel8086GUI
{
    public partial class Window : Form
    {
        public string pierwszyRejestrValue = "";
        string pierwszyRejestrID = "";
        string drugiRejestrValue = "";
        string drugiRejestrID = "";
        public string AHprzekaz = "";

        public Window()
        {
            InitializeComponent();
            dmemory.Visible = false;
            dmemoryValue.Visible = false;
            wynikmem.Visible = false;
            wynikmemvalue.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }


        static string HexToBinary(string hex) //szesnastkowy na binarny
        {
            return Convert.ToString(Convert.ToInt32(hex, 16), 2);
        }

        static string BinaryToHex(string binary) //binarny na szesnastkowy
        {
            if (binary == "1111111111111111111111111111111111111111111111111111111111111111")
            {
                return "0";
            }
            else
            {
                string hex = Convert.ToInt32(binary, 2).ToString("X");
                return hex;
            }
        }

        private string random_hex_value() // losowa wartosc szesnastkowa
        {
            var r = new Random();
            int A = r.Next(0, 255);
            string hexValue = A.ToString("X");
            return hexValue;
        }

        private void button1_Click(object sender, EventArgs e) //czyszczenie wartoœci rejestrów i wynikow
        {
            WyzerujRejestry();
        }

        private void randrejestry_Click(object sender, EventArgs e) //losowe wartoœci rejestrów
        {
            rejestrAH.Text = random_hex_value();
            rejestrBH.Text = random_hex_value();
            rejestrCH.Text = random_hex_value();
            rejestrDH.Text = random_hex_value();

            rejestrAL.Text = random_hex_value();
            rejestrBL.Text = random_hex_value();
            rejestrCL.Text = random_hex_value();
            rejestrDL.Text = random_hex_value();
        }

        private void showOutputs()
        {
            wynikAH.Text = rejestrAH.Text;
            wynikAL.Text = rejestrAL.Text;

            wynikBH.Text = rejestrBH.Text;
            wynikBL.Text = rejestrBL.Text;

            wynikCH.Text = rejestrCH.Text;
            wynikCL.Text = rejestrCL.Text;

            wynikDH.Text = rejestrDH.Text;
            wynikDL.Text = rejestrDL.Text;
        }

        //rejestry - stworzenie obiektu
        public void rejestrAH_TextChanged(object sender, EventArgs e)
        {

        }

        private void rejestrBH_TextChanged(object sender, EventArgs e)
        {

        }

        private void rejestrCH_TextChanged(object sender, EventArgs e)
        {

        }

        private void rejestrDH_TextChanged(object sender, EventArgs e)
        {

        }

        private void rejestrAL_TextChanged(object sender, EventArgs e)
        {

        }

        private void rejestrBL_TextChanged(object sender, EventArgs e)
        {

        }

        private void rejestrCL_TextChanged(object sender, EventArgs e)
        {

        }

        private void rejestrDL_TextChanged(object sender, EventArgs e)
        {

        }

        private void nadpiszWyniki(string pierwszy, string drugi, string pierwszyWynik, string drugiWynik) //funkcja nadpisuje wyniki operacji
        {
            wynikAH.BackColor = Color.Silver;
            wynikAL.BackColor = Color.Silver;

            wynikBH.BackColor = Color.Silver;
            wynikBL.BackColor = Color.Silver;

            wynikCH.BackColor = Color.Silver;
            wynikCL.BackColor = Color.Silver;

            wynikDH.BackColor = Color.Silver;
            wynikDL.BackColor = Color.Silver;
            wynikmemvalue.BackColor = Color.Silver;



            switch (pierwszyRejestrID)
            {
                case "AH":
                    wynikAH.Text = pierwszyWynik;
                    wynikAH.BackColor = Color.Yellow;
                    break;
                case "AL":
                    wynikAL.Text = pierwszyWynik;
                    wynikAL.BackColor = Color.Yellow;
                    break;
                case "BH":
                    wynikBH.Text = pierwszyWynik;
                    wynikBH.BackColor = Color.Yellow;
                    break;
                case "BL":
                    wynikBL.Text = pierwszyWynik;
                    wynikBL.BackColor = Color.Yellow;
                    break;
                case "CH":
                    wynikCH.Text = pierwszyWynik;
                    wynikCH.BackColor = Color.Yellow;
                    break;
                case "CL":
                    wynikCL.Text = pierwszyWynik;
                    wynikCL.BackColor = Color.Yellow;
                    break;
                case "DH":
                    wynikDH.Text = pierwszyWynik;
                    wynikDH.BackColor = Color.Yellow;
                    break;
                case "DL":
                    wynikDL.Text = pierwszyWynik;
                    wynikDL.BackColor = Color.Yellow;
                    break;

                default:
                    break;
            }

            switch (drugiRejestrID)
            {
                case "AH":
                    wynikAH.Text = drugiWynik;
                    wynikAH.BackColor = Color.Yellow;
                    break;
                case "AL":
                    wynikAL.Text = drugiWynik;
                    wynikAL.BackColor = Color.Yellow;
                    break;
                case "BH":
                    wynikBH.Text = drugiWynik;
                    wynikBH.BackColor = Color.Yellow;
                    break;
                case "BL":
                    wynikBL.Text = drugiWynik;
                    wynikBL.BackColor = Color.Yellow;
                    break;
                case "CH":
                    wynikCH.Text = drugiWynik;
                    wynikCH.BackColor = Color.Yellow;
                    break;
                case "CL":
                    wynikCL.Text = drugiWynik;
                    wynikCL.BackColor = Color.Yellow;
                    break;
                case "DH":
                    wynikDH.Text = drugiWynik;
                    wynikDH.BackColor = Color.Yellow;
                    break;
                case "DL":
                    wynikDL.Text = drugiWynik;
                    wynikDL.BackColor = Color.Yellow;
                    break;
                case "MEMORY":
                    wynikmemvalue.Text = drugiWynik;
                    wynikmemvalue.BackColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }


        //instrukcje 
        private void MOV_Click(object sender, EventArgs e) //rozkaz MOV
        {
            if (AreRejestryValid())
            {
                string pierwszyWynik = pierwszyRejestrValue;
                string drugiWynik = pierwszyRejestrValue;
                showOutputs();
                nadpiszWyniki(pierwszyRejestrID, drugiRejestrID, pierwszyWynik, drugiWynik);
                wyzeruj_wybory();
            }

        }

        private void XCHG_Click(object sender, EventArgs e) //rozkaz XCHG
        {
            if (AreRejestryValid())
            {
                string pierwszyWynik = drugiRejestrValue;
                string drugiWynik = pierwszyRejestrValue;
                showOutputs();
                nadpiszWyniki(pierwszyRejestrID, drugiRejestrID, pierwszyWynik, drugiWynik);
                wyzeruj_wybory();
            }
        }
        private void NOT_Click(object sender, EventArgs e) //rozkaz NOT
        {
            if (AreRejestryValid())
            {
                string pbin = HexToBinary(pierwszyRejestrValue);
                string dbin = HexToBinary(drugiRejestrValue);

                string pbinNOT = "";
                for (int i = 0; i < pbin.Length; i++) //Operacja logiczna NOT na liczbie binarnej pierwszego rejestru
                {
                    if (pbin[i] == '0')
                    {
                        pbinNOT += "1";
                    }
                    else if (pbin[i] == '1')
                    {
                        pbinNOT += "0";
                    }
                }

                string dbinNOT = "";
                for (int i = 0; i < dbin.Length; i++) //Operacja logiczna NOT na liczbie binarnej drugiego rejestru
                {
                    if (dbin[i] == '0')
                    {
                        dbinNOT += "1";
                    }
                    else if (dbin[i] == '1')
                    {
                        dbinNOT += "0";
                    }
                }

                string pierwszyWynik = Convert.ToString(BinaryToHex(pbinNOT));

                string drugiWynik = Convert.ToString(BinaryToHex(dbinNOT));
                showOutputs();
                nadpiszWyniki(pierwszyRejestrID, drugiRejestrID, pierwszyWynik, drugiWynik);
                wyzeruj_wybory();
            }
        }

        public static string IncrementBinaryString(string binary) //zwieksza binarna wartosc o 1
        {
            var digits = binary.Select(c => c - '0').ToList();

            for (int i = digits.Count - 1; i >= 0; i--)
            {
                if (digits[i] == 1)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] = 1;
                    break;
                }
            }

            if (digits[0] == 0)
            {
                digits.Insert(0, 1);
            }

            return string.Join("", digits);
        }

        private void INC_Click(object sender, EventArgs e) //instrukcja INC
        {
            if (AreRejestryValid())
            {
                string pbin = HexToBinary(pierwszyRejestrValue);
                string dbin = HexToBinary(drugiRejestrValue);

                string pierwszyWynik = BinaryToHex(IncrementBinaryString(pbin));
                string drugiWynik = BinaryToHex(IncrementBinaryString(dbin));

                showOutputs();
                nadpiszWyniki(pierwszyRejestrID, drugiRejestrID, pierwszyWynik, drugiWynik);
                wyzeruj_wybory();
            }

        }

        public string DecrementBinaryString(string binaryString) //zmniejsza binarna wartosc o 1
        {
            try
            {
                long binaryNumber = Convert.ToInt64(binaryString, 2);

                // Decrease the number by 1
                binaryNumber--;

                // Convert the number back to a binary string
                string stated = Convert.ToString(binaryNumber, 2);
                return stated;
            }
            catch
            {
                return "0";
            }


        }
        private void DEC_Click(object sender, EventArgs e) //instrukcja DEC
        {
            if (AreRejestryValid())
            {
                string pbin = HexToBinary(pierwszyRejestrValue);
                string dbin = HexToBinary(drugiRejestrValue);

                string pierwszyWynik = BinaryToHex(DecrementBinaryString(pbin));
                string drugiWynik = BinaryToHex(DecrementBinaryString(dbin));


                showOutputs();
                nadpiszWyniki(pierwszyRejestrID, drugiRejestrID, pierwszyWynik, drugiWynik);
                wyzeruj_wybory();
            }
        }
        private void AND_Click(object sender, EventArgs e) //instrukcja AND
        {
            if (AreRejestryValid())
            {
                string pbin = HexToBinary(pierwszyRejestrValue);
                string dbin = HexToBinary(drugiRejestrValue);

                int x = Convert.ToInt32(pbin, 2);
                int y = Convert.ToInt32(dbin, 2);

                int result = x & y;

                string wynik = Convert.ToString(result, 2);

                polejednorejestr.Text = BinaryToHex(wynik);
                wyzeruj_wybory();
            }
        }

        private void OR_Click(object sender, EventArgs e) //instrukcja OR
        {
            if (AreRejestryValid())
            {
                string pbin = HexToBinary(pierwszyRejestrValue);
                string dbin = HexToBinary(drugiRejestrValue);

                int x = Convert.ToInt32(pbin, 2);
                int y = Convert.ToInt32(dbin, 2);

                int result = x | y;

                string wynik = Convert.ToString(result, 2);

                polejednorejestr.Text = BinaryToHex(wynik);
                wyzeruj_wybory();
            }
        }

        private void XOR_Click(object sender, EventArgs e) //instrukcja XOR
        {
            if (AreRejestryValid())
            {
                string pbin = HexToBinary(pierwszyRejestrValue);
                string dbin = HexToBinary(drugiRejestrValue);

                int x = Convert.ToInt32(pbin, 2);
                int y = Convert.ToInt32(dbin, 2);

                int result = x ^ y;

                string wynik = Convert.ToString(result, 2);

                polejednorejestr.Text = BinaryToHex(wynik);
                wyzeruj_wybory();
            }
        }

        private void ADD_Click(object sender, EventArgs e) //instrukcja ADD
        {
            if (AreRejestryValid())
            {
                string pbin = HexToBinary(pierwszyRejestrValue);
                string dbin = HexToBinary(drugiRejestrValue);

                int length = Math.Max(pbin.Length, dbin.Length);
                pbin = pbin.PadLeft(length, '0');
                dbin = dbin.PadLeft(length, '0');

                string result = "";
                int carry = 0;

                for (int i = length - 1; i >= 0; i--)
                {
                    int sum = (pbin[i] - '0') + (dbin[i] - '0') + carry;

                    carry = sum / 2;

                    result = (sum % 2) + result;
                }

                if (carry > 0)
                {
                    result = carry + result;
                }


                polejednorejestr.Text = BinaryToHex(result);
                wyzeruj_wybory();
            }
        }

        private void SUB_Click(object sender, EventArgs e) //instrukcja SUB
        {
            if (AreRejestryValid())
            {
                string pbin = HexToBinary(pierwszyRejestrValue);
                string dbin = HexToBinary(drugiRejestrValue);

                int x = Convert.ToInt32(pbin, 2);
                int y = Convert.ToInt32(dbin, 2);
                int wyliczone = x - y;
                string decwyn = Convert.ToString(wyliczone);
                string wynik;

                if (decwyn[0] == '-')
                {
                    decwyn = decwyn.Substring(1);
                    string dectohex = Convert.ToString(Convert.ToInt32(decwyn, 10), 16);
                    wynik = "-" + dectohex.ToUpper();
                }
                else
                {
                    string dectohex = Convert.ToString(Convert.ToInt32(decwyn, 10), 16);
                    wynik = dectohex.ToUpper();
                }

                polejednorejestr.Text = wynik;
                wyzeruj_wybory();
            }
        }
        //koniec instrukcji

        //checked changed rejestr pierwszy - stworzenie obiektu
        private void pAH_CheckedChanged(object sender, EventArgs e)
        {
            pierwszyRejestrID = "AH";
            pierwszyRejestrValue = rejestrAH.Text;
        }

        private void pBH_CheckedChanged(object sender, EventArgs e)
        {
            pierwszyRejestrID = "BH";
            pierwszyRejestrValue = rejestrBH.Text;
        }

        private void pCH_CheckedChanged(object sender, EventArgs e)
        {
            pierwszyRejestrID = "CH";
            pierwszyRejestrValue = rejestrCH.Text;
        }

        private void pDH_CheckedChanged(object sender, EventArgs e)
        {
            pierwszyRejestrID = "DH";
            pierwszyRejestrValue = rejestrDH.Text;
        }

        private void pAL_CheckedChanged(object sender, EventArgs e)
        {
            pierwszyRejestrID = "AL";
            pierwszyRejestrValue = rejestrAL.Text;
        }

        private void pBL_CheckedChanged(object sender, EventArgs e)
        {
            pierwszyRejestrID = "BL";
            pierwszyRejestrValue = rejestrBL.Text;
        }

        private void pCL_CheckedChanged(object sender, EventArgs e)
        {
            pierwszyRejestrID = "CL";
            pierwszyRejestrValue = rejestrCL.Text;
        }

        private void pDL_CheckedChanged(object sender, EventArgs e)
        {
            pierwszyRejestrID = "DL";
            pierwszyRejestrValue = rejestrDL.Text;
        }

        //checked change rejestr drugi - stworzenie obiektu

        private void dAH_CheckedChanged(object sender, EventArgs e)
        {
            drugiRejestrID = "AH";
            drugiRejestrValue = rejestrAH.Text;
        }

        private void dBH_CheckedChanged(object sender, EventArgs e)
        {
            drugiRejestrID = "BH";
            drugiRejestrValue = rejestrBH.Text;
        }

        private void dCH_CheckedChanged(object sender, EventArgs e)
        {
            drugiRejestrID = "CH";
            drugiRejestrValue = rejestrCH.Text;
        }

        private void dDH_CheckedChanged(object sender, EventArgs e)
        {
            drugiRejestrID = "DH";
            drugiRejestrValue = rejestrDH.Text;
        }

        private void dAL_CheckedChanged(object sender, EventArgs e)
        {
            drugiRejestrID = "AL";
            drugiRejestrValue = rejestrAL.Text;
        }

        private void dBL_CheckedChanged(object sender, EventArgs e)
        {
            drugiRejestrID = "BL";
            drugiRejestrValue = rejestrBL.Text;
        }

        private void dCL_CheckedChanged(object sender, EventArgs e)
        {
            drugiRejestrID = "CL";
            drugiRejestrValue = rejestrCL.Text;
        }

        private void dDL_CheckedChanged(object sender, EventArgs e)
        {
            drugiRejestrID = "DL";
            drugiRejestrValue = rejestrDL.Text;
        }

        private void dmemory_CheckedChanged(object sender, EventArgs e)
        {
            if (dmemoryValue.Text == null || dmemoryValue.Text == "")
            {
                dmemory.Checked = false;
                dmemoryValue.Focus();
                dmemoryValue.BackColor = Color.Red;
            }
            else
            {
                dmemoryValue.BackColor = Color.Silver;
                drugiRejestrID = "MEMORY";
                drugiRejestrValue = memsim[Convert.ToInt32(dmemoryValue.Text)];
            }
        }

        private void wynikidorejestrow_Click(object sender, EventArgs e) //przerzuca wyniki do rejestrow
        {
            rejestrAH.Text = wynikAH.Text;
            rejestrAL.Text = wynikAL.Text;

            rejestrBH.Text = wynikBH.Text;
            rejestrBL.Text = wynikBL.Text;

            rejestrCH.Text = wynikCH.Text;
            rejestrCL.Text = wynikCL.Text;

            rejestrDH.Text = wynikDH.Text;
            rejestrDL.Text = wynikDL.Text;
        }

        private void wyzeruj_wybory() // zeruje wybory 
        {
            pAH.Checked = false;
            dAH.Checked = false;
            pBH.Checked = false;
            dBH.Checked = false;
            pCH.Checked = false;
            dCH.Checked = false;
            pDH.Checked = false;
            dDH.Checked = false;

            pAL.Checked = false;
            dAL.Checked = false;
            pBL.Checked = false;
            dBL.Checked = false;
            pCL.Checked = false;
            dCL.Checked = false;
            pDL.Checked = false;
            dDL.Checked = false;
            dmemory.Checked = false;
        }

        bool otworzZamknij = false;
        string[] memsim = new string[65538];
        public void openMemory_Click(object sender, EventArgs e)
        {
            otworzZamknij = !otworzZamknij;
            memory neForm = new memory();

            if (otworzZamknij)
            {
                dmemory.Visible = true;
                dmemoryValue.Visible = true;
                wynikmem.Visible = true;
                wynikmemvalue.Visible = true;

                AHprzekaz = rejestrAH.Text;


                neForm.dt.Columns.Add("nazwa rejestru", typeof(string));
                neForm.dt.Columns.Add("wartoœæ rejestru", typeof(string));

                neForm.dt.Rows.Add("AH", rejestrAH.Text);
                neForm.dt.Rows.Add("AL", rejestrAL.Text);

                neForm.dt.Rows.Add("BH", rejestrBH.Text);
                neForm.dt.Rows.Add("BL", rejestrBL.Text);

                neForm.dt.Rows.Add("CH", rejestrCH.Text);
                neForm.dt.Rows.Add("CL", rejestrCL.Text);

                neForm.dt.Rows.Add("DH", rejestrDH.Text);
                neForm.dt.Rows.Add("DL", rejestrDL.Text);

                var r = new Random();

                for (int i = 0; i < 65537; i++)
                {
                    string A = Convert.ToString(r.Next(0, 255));
                    string dectohex = Convert.ToString(Convert.ToInt32(A, 10), 16);
                    neForm.dt.Rows.Add(i, dectohex.ToUpper());
                    memsim[i] = dectohex.ToUpper();
                }

                openMemory.Text = "Zamknij podgl¹d symulowanej pamiêci";

                neForm.Show();
            }
            else if (!otworzZamknij)
            {
                dmemory.Visible = false;
                dmemoryValue.Visible = false;
                wynikmem.Visible = false;
                wynikmemvalue.Visible = false;
                openMemory.Text = "Otwórz podgl¹d symulowanej pamiêci";
                Application.OpenForms["memory"].Close();
            }


        }

        public bool IsValidHex(string str) //Funkcja sprawdzaj¹ca czy podana liczba jest poprawn¹ liczb¹ szesnastkow¹.
        {
            var regex = new Regex("^[0-9a-fA-F]+$");
            return regex.IsMatch(str);
        }

        public bool AreRejestryValid() //funkcja sprawdzaj¹ca poprawnoœæ rejestrów przy pomocy powy¿szej funkcji.
        {
            if (!IsValidHex(rejestrAH.Text) || !IsValidHex(rejestrAL.Text) || !IsValidHex(rejestrBH.Text) || !IsValidHex(rejestrBL.Text) || !IsValidHex(rejestrCH.Text) || !IsValidHex(rejestrCL.Text) || !IsValidHex(rejestrDH.Text) || !IsValidHex(rejestrDL.Text))
            {
                error.Text = "Conajmniej jedna z podanych wartoœci nie jest liczb¹ szesnastkow¹!";
                wynikAH.Text = "";
                wynikBH.Text = "";
                wynikCH.Text = "";
                wynikDH.Text = "";

                wynikAL.Text = "";
                wynikBL.Text = "";
                wynikCL.Text = "";
                wynikDL.Text = "";
                polejednorejestr.Text = "";
                return false;
            }
            error.Text = "";
            return true;
        }

        public void WyzerujRejestry() //funkcja zeruj¹ca rejestry
        {
            rejestrAH.Text = "";
            rejestrBH.Text = "";
            rejestrCH.Text = "";
            rejestrDH.Text = "";

            rejestrAL.Text = "";
            rejestrBL.Text = "";
            rejestrCL.Text = "";
            rejestrDL.Text = "";

            wynikAH.Text = "";
            wynikBH.Text = "";
            wynikCH.Text = "";
            wynikDH.Text = "";

            wynikAL.Text = "";
            wynikBL.Text = "";
            wynikCL.Text = "";
            wynikDL.Text = "";
            polejednorejestr.Text = "";
            wynikmemvalue.Text = "";
            dmemoryValue.Text = "";


            wynikAH.BackColor = Color.Silver;
            wynikAL.BackColor = Color.Silver;

            wynikBH.BackColor = Color.Silver;
            wynikBL.BackColor = Color.Silver;

            wynikCH.BackColor = Color.Silver;
            wynikCL.BackColor = Color.Silver;

            wynikDH.BackColor = Color.Silver;
            wynikDL.BackColor = Color.Silver;

            wynikmemvalue.BackColor = Color.Silver;
        }


    }
}
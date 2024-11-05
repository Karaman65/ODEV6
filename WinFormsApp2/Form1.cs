namespace WinFormsApp2
{
    // Form1 s�n�f�, uygulaman�n ana formunu temsil eder
    public partial class Form1 : Form
    {
        // Form1'in constructor'� (ba�lat�c�) - Form1 y�klendi�inde �a�r�l�r
        public Form1()
        {
            InitializeComponent();  // Formu ba�latan otomatik metod
        }

        // Operat�rlerin �nceli�ini belirlemek i�in kullan�lacak fonksiyon
        private int GetPrecedence(char op)
        {
            // '+' ve '-' operat�rleri en d���k �nceli�e sahip (1)
            if (op == '+' || op == '-') return 1;

            // '*' ve '/' operat�rleri orta �nceli�e sahip (2)
            if (op == '*' || op == '/') return 2;

            // '^' operat�r� en y�ksek �nceli�e sahip (3)
            if (op == '^') return 3;  // �s i�lemi daha y�ksek �ncelikli

            // Ge�ersiz bir operat�r verilirse 0 d�ner
            return 0;
        }

        // �nfix ifadeyi postfix ifadeye d�n��t�rmek i�in fonksiyon
        private string InfixToPostfix(string infix)
        {
            // Y���n�n (stack) tan�mlanmas�
            Stack<char> stack = new Stack<char>();
            // Sonu� string'i
            string result = "";

            // Her karakteri infix ifadesinde tek tek kontrol et
            foreach (char c in infix)
            {
                if (char.IsLetterOrDigit(c)) // E�er karakter bir harf veya rakam ise (operand)
                {
                    result += c;  // Sonu� string'ine ekle
                }
                else if (c == '(') // E�er karakter sol parantez '(' ise
                {
                    stack.Push(c);  // Parantezi y���na ekle
                }
                else if (c == ')') // E�er karakter sa� parantez ')' ise
                {
                    // Y���ndaki operat�rleri al ve result'a ekle
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result += stack.Pop();
                    }
                    stack.Pop(); // Sol parantezi ��kar
                }
                else // E�er karakter bir operat�r (+, -, *, /, ^) ise
                {
                    // Operat�r�n �nceli�ine g�re y���ndaki daha y�ksek �ncelikli operat�rleri ��kar
                    while (stack.Count > 0 && GetPrecedence(c) <= GetPrecedence(stack.Peek()))
                    {
                        result += stack.Pop(); // Daha y�ksek �ncelikli operat�rleri result'a ekle
                    }
                    stack.Push(c); // Yeni operat�r� y���na ekle
                }
            }

            // Y���ndaki t�m operat�rleri son bir kez ��kar
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }

            // Sonu� (Postfix) d�nd�r�l�r
            return result;
        }

        // �nfix ifadeyi prefix ifadeye d�n��t�rmek i�in fonksiyon
        private string InfixToPrefix(string infix)
        {
            // 1. Ad�m: �nfix ifadesini tersine �evir
            char[] infixArray = infix.ToCharArray();  // �nfix ifadesini karakter dizisine d�n��t�r
            Array.Reverse(infixArray);  // Diziyi tersine �evir
            string reversedInfix = new string(infixArray);  // Ters �evrilen infix ifadesini string'e d�n��t�r

            // 2. Ad�m: Ters �evrilen infix ifadesini postfix'e d�n��t�r
            string reversedPostfix = InfixToPostfix(reversedInfix);  // Postfix d�n���m�n� ger�ekle�tir

            // 3. Ad�m: Postfix ifadesini tersine �evirerek prefix'i elde et
            char[] reversedPostfixArray = reversedPostfix.ToCharArray();  // Postfix'i karakter dizisine �evir
            Array.Reverse(reversedPostfixArray);  // Diziyi tersine �evir
            return new string(reversedPostfixArray);  // Ters �evrilmi� postfix'i yeni string olarak d�nd�r
        }

        // Postfix d�n���m� i�lemi
        private void button1_Click(object sender, EventArgs e)
        {
            string infix = txtInfix.Text;  // Kullan�c�dan al�nan infix ifadeyi oku
            string postfix = InfixToPostfix(infix);  // Infix'i Postfix'e d�n��t�r
            lblPostfix.Text = "Postfix: " + postfix;  // Sonucu lblPostfix etiketinde g�ster
        }

        // Prefix d�n���m� i�lemi
        private void button2_Click(object sender, EventArgs e)
        {
            string infix = txtInfix.Text;  // Kullan�c�dan al�nan infix ifadeyi oku
            string prefix = InfixToPrefix(infix);  // Infix'i Prefix'e d�n��t�r
            lblPrefix.Text = "Prefix: " + prefix;  // Sonucu lblPrefix etiketinde g�ster
        }
    }
}

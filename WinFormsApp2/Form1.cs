namespace WinFormsApp2
{
    // Form1 sýnýfý, uygulamanýn ana formunu temsil eder
    public partial class Form1 : Form
    {
        // Form1'in constructor'ý (baþlatýcý) - Form1 yüklendiðinde çaðrýlýr
        public Form1()
        {
            InitializeComponent();  // Formu baþlatan otomatik metod
        }

        // Operatörlerin önceliðini belirlemek için kullanýlacak fonksiyon
        private int GetPrecedence(char op)
        {
            // '+' ve '-' operatörleri en düþük önceliðe sahip (1)
            if (op == '+' || op == '-') return 1;

            // '*' ve '/' operatörleri orta önceliðe sahip (2)
            if (op == '*' || op == '/') return 2;

            // '^' operatörü en yüksek önceliðe sahip (3)
            if (op == '^') return 3;  // Üs iþlemi daha yüksek öncelikli

            // Geçersiz bir operatör verilirse 0 döner
            return 0;
        }

        // Ýnfix ifadeyi postfix ifadeye dönüþtürmek için fonksiyon
        private string InfixToPostfix(string infix)
        {
            // Yýðýnýn (stack) tanýmlanmasý
            Stack<char> stack = new Stack<char>();
            // Sonuç string'i
            string result = "";

            // Her karakteri infix ifadesinde tek tek kontrol et
            foreach (char c in infix)
            {
                if (char.IsLetterOrDigit(c)) // Eðer karakter bir harf veya rakam ise (operand)
                {
                    result += c;  // Sonuç string'ine ekle
                }
                else if (c == '(') // Eðer karakter sol parantez '(' ise
                {
                    stack.Push(c);  // Parantezi yýðýna ekle
                }
                else if (c == ')') // Eðer karakter sað parantez ')' ise
                {
                    // Yýðýndaki operatörleri al ve result'a ekle
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result += stack.Pop();
                    }
                    stack.Pop(); // Sol parantezi çýkar
                }
                else // Eðer karakter bir operatör (+, -, *, /, ^) ise
                {
                    // Operatörün önceliðine göre yýðýndaki daha yüksek öncelikli operatörleri çýkar
                    while (stack.Count > 0 && GetPrecedence(c) <= GetPrecedence(stack.Peek()))
                    {
                        result += stack.Pop(); // Daha yüksek öncelikli operatörleri result'a ekle
                    }
                    stack.Push(c); // Yeni operatörü yýðýna ekle
                }
            }

            // Yýðýndaki tüm operatörleri son bir kez çýkar
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }

            // Sonuç (Postfix) döndürülür
            return result;
        }

        // Ýnfix ifadeyi prefix ifadeye dönüþtürmek için fonksiyon
        private string InfixToPrefix(string infix)
        {
            // 1. Adým: Ýnfix ifadesini tersine çevir
            char[] infixArray = infix.ToCharArray();  // Ýnfix ifadesini karakter dizisine dönüþtür
            Array.Reverse(infixArray);  // Diziyi tersine çevir
            string reversedInfix = new string(infixArray);  // Ters çevrilen infix ifadesini string'e dönüþtür

            // 2. Adým: Ters çevrilen infix ifadesini postfix'e dönüþtür
            string reversedPostfix = InfixToPostfix(reversedInfix);  // Postfix dönüþümünü gerçekleþtir

            // 3. Adým: Postfix ifadesini tersine çevirerek prefix'i elde et
            char[] reversedPostfixArray = reversedPostfix.ToCharArray();  // Postfix'i karakter dizisine çevir
            Array.Reverse(reversedPostfixArray);  // Diziyi tersine çevir
            return new string(reversedPostfixArray);  // Ters çevrilmiþ postfix'i yeni string olarak döndür
        }

        // Postfix dönüþümü iþlemi
        private void button1_Click(object sender, EventArgs e)
        {
            string infix = txtInfix.Text;  // Kullanýcýdan alýnan infix ifadeyi oku
            string postfix = InfixToPostfix(infix);  // Infix'i Postfix'e dönüþtür
            lblPostfix.Text = "Postfix: " + postfix;  // Sonucu lblPostfix etiketinde göster
        }

        // Prefix dönüþümü iþlemi
        private void button2_Click(object sender, EventArgs e)
        {
            string infix = txtInfix.Text;  // Kullanýcýdan alýnan infix ifadeyi oku
            string prefix = InfixToPrefix(infix);  // Infix'i Prefix'e dönüþtür
            lblPrefix.Text = "Prefix: " + prefix;  // Sonucu lblPrefix etiketinde göster
        }
    }
}

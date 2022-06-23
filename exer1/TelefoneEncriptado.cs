namespace exer1
{
    public static class TelefoneEncriptado
    {

        public static string Conversor(string encriptado)
        {
            List<string> convertido = new List<string>();
            foreach (var item in encriptado)
            {
                if (item.Equals('A') || item.Equals('B') || item.Equals('C'))
                {
                    convertido.Add("2");
                }
                else if (item.Equals('D') || item.Equals('E') || item.Equals('F'))
                {
                    convertido.Add("3");
                }
                else if (item.Equals('G') || item.Equals('H') || item.Equals('I'))
                {
                    convertido.Add("4"); ;
                }
                else if (item.Equals('J') || item.Equals('K') || item.Equals('L'))
                {
                    convertido.Add("5");
                }
                else if (item.Equals('M') || item.Equals('N') || item.Equals('O'))
                {
                    convertido.Add("6");
                }
                else if (item.Equals('P') || item.Equals('Q') || item.Equals('R') || item.Equals('S'))
                {
                    convertido.Add("7");
                }
                else if (item.Equals('T') || item.Equals('U') || item.Equals('V'))
                {
                    convertido.Add("8");
                }
                else if (item.Equals('W') || item.Equals('X') || item.Equals('Y') || item.Equals('Z'))
                {
                    convertido.Add("9");
                }
                else convertido.Add(item.ToString());
            }
            return String.Join("", convertido.ToArray());
        }

    }
}
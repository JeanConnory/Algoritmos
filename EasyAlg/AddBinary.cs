namespace EasyAlg;

public static class AddBinary
{
    public static string AddBinaryMethod(string a, string b)
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        var resultado = new System.Text.StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int bitA = i >= 0 ? a[i] - '0' : 0;
            int bitB = j >= 0 ? b[j] - '0' : 0;

            int soma = bitA + bitB + carry;
            resultado.Insert(0, soma % 2); // Adiciona o bit resultante
            carry = soma / 2;              // Atualiza o carry

            i--;
            j--;
        }

        return resultado.ToString();
    }
}

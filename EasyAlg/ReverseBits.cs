namespace EasyAlg;

public static class ReverseBits
{
    public static int ReverseBitsMethod(int n)
    {
        int result = 0;

        for (int i = 0; i < 32; i++)
        {
            result <<= 1;         // desloca resultado para a esquerda
            result |= n & 1;      // adiciona o bit menos significativo de n
            n >>= 1;              // desloca n para a direita
        }

        return result;
    }
}

namespace EasyAlg.Sorts
{
    public static class QuickSort
    {
        public static int[] QuicksortMethod(int[] v, int start_pos, int end_pos)
        {
            int pivot = v[start_pos];
            int l = start_pos;
            int r = end_pos;

            while (l <= r)
            {
                while (v[l] < pivot) l++;
                while (v[r] > pivot) r--;

                if (l <= r)
                {
                    (v[l], v[r]) = (v[r], v[l]);
                    l++;
                    r--;
                }
            }

            if (start_pos < r) QuicksortMethod(v, start_pos, r);
            if (l < end_pos) QuicksortMethod(v, l, end_pos);

            return v;
        }
    }
}

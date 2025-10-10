namespace EasyAlg;

public static class FirstBadVersion
{
    public static int FirstBadVersionMethod(int n)
    {
        int left = 1;
        int right = n;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (IsBadVersion(mid))
            {
                if (mid == 1 || (mid - 1 > 0 && !IsBadVersion(mid - 1)))
                    return mid;
                else
                    right = mid;
            }
            else
                left = mid + 1;
        }
        return left;
    }

    public static bool IsBadVersion(int badVersion)
    {
        if (badVersion >= 4)
            return true;
        return false;
    }
}

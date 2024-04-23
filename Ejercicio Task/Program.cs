int[] nums = { 5, 2, 9, 1, 3 };

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (nums[j] > nums[j + 1])
        {
            int aux = nums[j];
            nums[j] = nums[j + 1];
            nums[j + 1] = aux;
        }
    }
}

for ( int i = 0; i < 7; i++)
{
    Console.WriteLine(nums[i]);
}
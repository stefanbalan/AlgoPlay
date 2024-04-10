namespace AlgoPlay.Test;

public class TestP3
{
    public string Solution(string S)
    {
        var input = S.ToCharArray();
        var output = new char[S.Length];

        int insert = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (insert == 0)
            {
                output[insert] = input[i];
                insert += 1;
                continue;
            }

            switch (output[insert - 1])
            {
                case 'A':
                    if (input[i] == 'B')
                    {
                        output[insert - 1] = '\0';
                        insert -= 1;
                    }
                    else
                    {
                        output[insert] = input[i];
                        insert += 1;
                    }

                    break;
                case 'B':
                    if (input[i] == 'A')
                    {
                        output[insert - 1] = '\0';
                        insert -= 1;
                    }
                    else
                    {
                        output[insert] = input[i];
                        insert += 1;
                    }

                    break;
                case 'C':
                    if (input[i] == 'D')
                    {
                        output[insert - 1] = '\0';
                        insert -= 1;
                    }
                    else
                    {
                        output[insert] = input[i];
                        insert += 1;
                    }

                    break;
                case 'D':
                    if (input[i] == 'C')
                    {
                        output[insert - 1] = '\0';
                        insert -= 1;
                    }
                    else
                    {
                        output[insert] = input[i];
                        insert += 1;
                    }

                    break;
            }
        }


        return new string(output, 0, insert);
    }
}
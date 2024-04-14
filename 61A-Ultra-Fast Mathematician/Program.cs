using System.Text;

string line1 = Console.ReadLine();
string line2 = Console.ReadLine();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < line1.Length; i++)
{
    sb.Append(line1[i] == line2[i] ? '0' : '1');
}
Console.WriteLine(sb.ToString());

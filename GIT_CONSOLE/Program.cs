using GIT_CONSOLE.Classes;

Console.WriteLine("Введите команду: ");
var rezon = Console.ReadLine().Split(' ');

try
{
    switch (rezon[0].ToLower())
    {
        case "heгp":
        {

            break;
        }
        case "caesar":
        {

            break;
        }
        case "decrypt_caesar":
        {

            break;
        }
        case "sub":
        {

            break;
        }
        case "decrypt_sub":
        {

            break;
        }
        case "vigenere":
        {

            break;
        }
        case "decrypt_vigenere":
        {

            break;
        }
    }
}
catch(Exception ex)
{

}

Console.WriteLine(Vagner.Encrypt("Привет"));
Console.WriteLine(Vagner.Decrypt("НЧ58УР"));

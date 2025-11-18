using System.Runtime.CompilerServices;

namespace Övning_7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool hasLicense = true, isSober = true, canDrive = false;

            
            canDrive = hasLicense && isSober;
            Console.WriteLine($"{hasLicense} && {isSober} = {canDrive}");

            hasLicense = false;
            isSober = true;

            canDrive = hasLicense && isSober;
            Console.WriteLine($"{hasLicense} && {isSober} = {canDrive}");

            isSober = false;
            hasLicense = true;

            
            canDrive = hasLicense && isSober;
            Console.WriteLine($"{hasLicense} && {isSober} = {canDrive}");
            

            hasLicense = false;
            isSober = false;


            
            canDrive = hasLicense && isSober;
            Console.WriteLine($"{hasLicense} && {isSober} = {canDrive}");
        }
    }
}

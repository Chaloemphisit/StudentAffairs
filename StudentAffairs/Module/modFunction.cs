using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAffairs.Module {
    class modFunction {
    //    Public Function generatePassword(Optional ByVal n As Integer = 8) As String
    //    'the following is the string that will hold the salt charachters
    //    Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
    //    Dim salt As String = ""
    //    Dim rnd As New Random
    //    Dim sb As New StringBuilder
    //    For i As Integer = 1 To n 'Length of the salt
    //        Dim x As Integer = rnd.Next(0, mix.Length - 1)
    //        salt &= (mix.Substring(x, 1))
    //    Next
    //    Return salt
    //End Function

        public static string passwordGen(int n=8) {
            String ch = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string result = "";
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for(int i=1; i <= n; i++) {
                int x = rnd.Next(0, ch.Length - 1);
                result += ch.Substring(x, 1);
            }

            return result;

        }

        public static string UsernameGen(string id) {

            return "T" + id;
        }

    //Public Function generateUsername(id As String) As String
    //    Dim username As String
    //    username = "T" & id
    //    Return username
    //End Function
    }
}

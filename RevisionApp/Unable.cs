
char[] ch = {'h' ,'A' ,'c' ,'k' ,'3' ,'r' ,'r' ,'4' ,'n' ,'k'};
            char[] ch2= new char [13];
            ch2[4] = '*'; ch2[7] = '0'; ch2[10] = '0';
            
           for (int i = 0; i <ch.Length; i++)
           {
               if ( char.IsLower(ch[0]) && char.IsUpper(ch[1]) || char.IsDigit(ch[4]))
               {
                // ch[7] = ch2[0]; ch[4]=ch2[1]; ch[1]= ch2[2]; ch[0]= ch2[3];  ch[2] = ch2[5]; ch[3] = ch2[6]; /*ch2[7] = '0'; ch[5] = ch2[8]; ch[6] = ch2[9]; ch2[10] = '0'; ch[8] = ch[11]; ch[9] = ch2[12];
                  ( ch[0], ch[1], ch[2], ch[3], ch[4], ch[5], ch[6], ch[7], ch[8], ch[9]) = ( ch[7], ch[4], ch[1], ch[0], ch[2], ch[3], ch[5], ch[6], ch[8], ch[9]);
                  Console.WriteLine(string.Format($"{ch[0]} {ch[1]} {ch[2]} {ch[3]} {ch2[4]} {ch[4]} {ch[5]} {ch2[7]} {ch[6]} {ch[7]} {ch2[10]} {ch[8]} {ch[9]}"));
                  //Console.WriteLine();
                  
                  
                   //word2 = word2.Replace('A',s);
                   Console.WriteLine($"A");
               }
               else if (char.IsDigit(ch[4]))
               {
                 // i++;
                 (ch[0],ch[4]) = (ch[4], ch[0]);
                  Console.Write(string.Format($"{ch2[0]} {ch2[1]} {ch2[2]} {ch2[3]} {ch2[4]} {ch2[5]} {ch2[6]} {ch2[7]} {ch2[8]} {ch2[9]}"));
                   Console.WriteLine($"ch[{0}]");
                   
               }
               else
               {
                  Console.WriteLine($"{ch2[9]}");
                  
               }
               
         }
        //     char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        //     Console.WriteLine("Enter your word :");
        //     char[] word = (Console.ReadLine()).ToCharArray();

        //     for (int i15 = 0; i15 < word.Length; i15++)
        //     {
        //         for (int j15 = 0; j15 < alphabet.Length; j15++)
        //         {
        //             if (word[i15] == alphabet[j15])
        //             {
        //                Console.Write("{0} ", j15);
        //             }
        //         }
        //     }
               
        //   /*  Console.WriteLine("Enter string: ");
        //     string word2 = Console.ReadLine();//"ABABAB";
        //     var s = 'B';
        //     word2 = word2.Replace('A',s);
        //     Console.WriteLine(word2);
            
        //     //s = word.Select(x=> x == 'A' ? 'B':(x=='B' ? 'A' : x)).ToArray();
        //     //word = new String(s);*/

        //     int[] we = {1,2,3,4};
        //     //int[] ew = new int[5];
        //     (we[0], we[2]) = (we[2], we[0]);
        //     Console.WriteLine(string.Format($"{we[0]} {we[1]} {we[2]} {we[3]}"));*/
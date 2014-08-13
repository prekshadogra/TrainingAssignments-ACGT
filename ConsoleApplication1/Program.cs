using System;
namespace Sample
{
    class Program
    {
            public int minChanges(int maxPeriod, String[] acgt) {
                String abc = "";
                for (int i = 0; i < acgt.Length; i++) {
                    abc = abc + acgt[i];
                    int len = 1;
                    while (len <= maxPeriod) {
                        int sub = 0;
                        for (int j = 0; j < len; j++) { 
                        int [] arr= {0, 0, 0, 0};
                            for(int z=j; z< abc.Length; z+= len){
                                    switch(abc.element){
                                        case 'A':
                                            arr[0]++;
                                            break;
                                        case 'B':
                                            arr[1]++;
                                            break;
                                        case 'C':
                                            arr[2]++;
                                            break;
                                        case 'D':
                                            arr[3]++;
                                            break;
                                    }
                            }
                            int max= arr[0];
                            for(int i: arr)
                                if(max<i)
                                    max= i;
                            sub+= (abc.Length-j)/ len- max;
                            if((abc.Length- j)% len !=0){
                            sub++;
                            }
                            if(sub< min)
                                min=sub;
                            len++;
                        }
                        return min;
                    }
                }
            }
        
        static void Main(string[] args)
        {

        }
    }
}

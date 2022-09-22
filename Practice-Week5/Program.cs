using System;
public class Program {

    static void Main (){
        int n = n_input();
        print_Hamlet1(n);
        int np = pyramid_floor();
        block_pyramid_calculaton1(np);
        int m = input_horormor_count();
        int[] numpick =num_pick(m);
        print_hrm(numpick,m);
    }








//Hamlet
    static void print_Hamlet1(int n){
        string[] hamlet = new string[n];
        foreach (string hamlet_input in hamlet){
            Console.WriteLine("Hamlet");
        }
    }
    static int n_input () {
        Console.Write("Please input hamlet u want :");
        string n = Console.ReadLine();
        if (int.TryParse(n,out int num))
            return num;
        else throw new ArgumentException("Please Try again");
    }
    /*
    static void print_Hamlet(int n){
        for (int i=0;i<n;i++){
            Console.WriteLine("Hamlet");
        }
    }
    */
//pyramid
    static int pyramid_floor(){
        Console.Write("Count of pyramid floor :");
        string py = Console.ReadLine();
        if (int.TryParse(py,out int nump))
            return nump;
        else throw new ArgumentException("Please Try input new Count of pyramid floor");
    }
        static void block_pyramid_calculaton1 (int np){
            int chec = np%2; 
            double total=0;
            double[] block = new double [np];  
            if (chec != 0) {
            double a = np+4;
            foreach(int block_count in block){
                a -= 2;
                block[block_count] = Math.Pow(a,2) ;
                total += block[block_count];
            }
            }
            else if (chec == 0){
            double a = np+3;
            foreach(int block_count in block){
                a -= 2;
                block[block_count] = Math.Pow(a,2) ;
                total += block[block_count];
                }
            }
            Console.WriteLine("All block use = {0}",total);
            }   
    /*
    static int block_pyramid_calculator (int np){
        int block=1,blockuse,block_all_use =0;
        for (int i=1;i<np;i++){
            block +=2;
            blockuse = block*block;
            block_all_use += blockuse;
        }
        return block_all_use+1;
    */
//
    static int input_horormor_count(){
        int m = int.Parse(Console.ReadLine());
        return m;
    }
    static int[] num_pick (int m){
        int []num_pick = new int[m];
        for (int i=0;i<m;i++){
            num_pick[i] = int.Parse(Console.ReadLine());
        }
        return num_pick;
    }
    static void print_hrm (int []numpick,int m){
        int a =0,low =100000000,horrormor_number=1,allhorrormor = 1;
        foreach(int ll in numpick){
            if (numpick[a] < low){
                low = numpick[a];
                a++;
            }
        }
        for (int i=1;i<low;low--){
            int count=0,k=0;
            foreach(int wat in numpick){
                int cal;
                cal = numpick[k]%low;
                k++;
                if (cal==0){
                    count +=1;
                }
            }
            if (count==m){
                k = 0;
                horrormor_number=low;
                foreach(int all in numpick){
                    numpick[k] = numpick[k]/low;
                    k++;
                }
                allhorrormor *= horrormor_number;
            }
        }
        Console.WriteLine("จำนวนหารร่วมมากคือ = {0}",allhorrormor);
    }
}


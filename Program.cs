using System;
namespace Nova_pasta
{
    class Program
    {
        static string escolha_maquina(){
            string [] lista = new string []{"pedra", "papel", "tesoura"};
            Random novo = new Random();
            string escolha_pc = lista[novo.Next(2)];
            return escolha_pc;
            
        }

        static string escolha_usuario(){
            Console.WriteLine("Pedra Papel ou Tesoura? ");
            string esc_usuario = Console.ReadLine();
            esc_usuario = esc_usuario.ToLower();
            if(esc_usuario == "pedra"){
                return esc_usuario;
            }
            else if(esc_usuario == "tesoura"){
                return esc_usuario;
            }
            else if(esc_usuario == "papel"){
                return esc_usuario;
            }
            else{
                Console.WriteLine("Opção invalida, tente novamente!");
                escolha_usuario();
            }
            return esc_usuario;
        }

        static void Main(string[] args)
        {
            int vitoriajogador = 0;
            int vitoriamaquina = 0;
            int verifica = 0;
            while (verifica == 0){
            string esc_usuario = escolha_usuario();
            string esc_maquina = escolha_maquina();
            if(esc_usuario == "pedra" && esc_maquina == "tesoura" || esc_usuario == "tesoura" && esc_maquina =="papel" || esc_usuario == "papel" && esc_maquina == "pedra"){
                Console.WriteLine("{0} ganha de {1}", esc_usuario, esc_maquina);
                vitoriajogador = vitoriajogador +1;
            }
            else if (esc_usuario==esc_maquina){
                Console.WriteLine("Empate\n{0} = {1}", esc_usuario, esc_maquina);
            }
            else{
                Console.WriteLine("{0} ganha de {1}", esc_maquina, esc_usuario);
                vitoriamaquina = vitoriamaquina+1;
            }
            
            Console.WriteLine("Vitorias Maquina: {0}", vitoriamaquina);
            Console.WriteLine("Vitorias Jogador: {0}", vitoriajogador);
            Console.WriteLine("Para continuar tecle 0: ");
            verifica = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}

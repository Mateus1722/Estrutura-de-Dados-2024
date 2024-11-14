using System;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Quiz em Árvore!");
            
            // Criando a árvore do quiz
            Node root = new Node("Você gosta de programar?");
            root.Yes = new Node("Você prefere C# a outras linguagens?");
            root.No = new Node("Talvez programação não seja o seu forte, mas continue explorando!");
            
            root.Yes.Yes = new Node("Ótimo! C# é uma linguagem poderosa.");
            root.Yes.No = new Node("Você está interessado em aprender mais sobre C#?");
            
            root.Yes.No.Yes = new Node("Excelente! Aprender C# pode abrir várias oportunidades.");
            root.Yes.No.No = new Node("Tudo bem! Cada um tem suas preferências.");
            
            // Iniciando o quiz a partir da raiz
            RunQuiz(root);
        }

        // Classe Node representa cada pergunta/resposta do quiz
        class Node
        {
            public string Text { get; }
            public Node Yes { get; set; }
            public Node No { get; set; }

            public Node(string text)
            {
                Text = text;
                Yes = null;
                No = null;
            }

            public bool IsLeaf()
            {
                return Yes == null && No == null;
            }
        }

        // Método que executa o quiz usando a árvore
        static void RunQuiz(Node node)
        {
            if (node == null) return;

            Console.WriteLine(node.Text);

            // Se for uma folha, significa que é uma resposta final
            if (node.IsLeaf())
            {
                return;
            }

            // Ler a resposta do usuário
            var resposta = Console.ReadLine().ToUpper();

            if (resposta == "Y")
            {
                RunQuiz(node.Yes);
            }
            else if (resposta == "N")
            {
                RunQuiz(node.No);
            }
            else
            {
                Console.WriteLine("Resposta inválida. Tente novamente.");
                RunQuiz(node); // Volta para a mesma pergunta em caso de resposta inválida
            }
        }
    }
}

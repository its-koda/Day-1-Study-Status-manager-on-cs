# Study Status Manager (C#) | Gerenciador de Status de Estudo (C#) 🪐

<details open>
  <summary>🌐 <b>English Version</b></summary>
  <br />

  A simple script first made in Python (but now in C#), to organize the study process, created on my first day of solo study.

  ## 🔌 How does it work?
  * It collects info about the subject's name, progress percentage, and the next task via keyboard.
  * Saves all info automatically in a local `.txt` file.
  * Keeps a history log (it doesn't overwrite previous records).

  ## 🌊 Today's learning (again!):
  * File manipulation in C# using `using System.IO;` and `File.AppendAllText`.
  * Structure of a basic algorithm in C# and its differences from Python (same logic, different syntax).
  * Usage of Project files (`.csproj`).
  * Discovery of compilation artifacts.
  * Language Comparison: Found C# to be more strict and explicit than Python, yet strangely reminiscent of Portugol structures.

  ## 📸 Infrastructure learning in C#
  * **Compilation Artifacts:** Every time C# runs, it generates compilation artifacts—temporary files used to execute the algorithm. They can be safely deleted (they will be recreated upon the next build).
  * **Type Safety & Strictness:** C# syntax is more explicit and specific than Python's, which enforces greater security and structure in the code.
  * **Project Identity:** C# requires an identity file (`.sln` or `.csproj`) to run, specifying the project type. In this case, it's a Console Application.
  * **.csproj vs .sln:** A `.csproj` manages a single project/algorithm, while a `.sln` (Solution) connects multiple projects that work together. For example, if you have a web system with 4 distinct modules, you group them using a `.sln` and define each module's specific role with its respective `.csproj`.
  * **CLI Commands:** It is easier to open the terminal (`Ctrl + '`) and use `dotnet new console` to generate a console project with its `.csproj`.
  * For a solution file, the command is more specific: `dotnet new sln -n ProjectName` (where `-n` stands for name).

  ---
  *Learning different languages with the same algorithm.*
</details>

<details>
  <summary>🌐 <b>Versão em Português</b></summary>
  <br />

  Um script simples feito inicialmente em Python (mas agora em C#), para organizar o processo de estudo, criado no meu primeiro dia de estudos solo.

  ## 🔌 Como funciona?
  * Coleta informações sobre o nome da matéria, porcentagem de progresso e a próxima tarefa via teclado.
  * Salva todas as informações automaticamente em um arquivo `.txt` local.
  * Mantém um histórico de logs (não apaga o que foi escrito anteriormente).

  ## 🌊 Aprendizados de hoje (de novo!):
  * Manipulação de arquivos em C# utilizando `using System.IO;` e `File.AppendAllText`.
  * Estrutura de um algoritmo básico em C# e suas diferenças em relação ao Python (mesma lógica, sintaxe diferente).
  * Uso de arquivos de projeto (`.csproj`).
  * Descoberta de artefatos de compilação.
  * Achei o C# mais rígido e explícito que o Python, mas curiosamente parecido com as estruturas do Portugol.

  ## 📸 Aprendizados de infraestrutura em C#
  * **Artefatos de Compilação:** Toda vez que o C# executa algo, ele gera arquivos com artefatos de compilação, códigos temporários que ele usa para rodar o algoritmo. Eles podem ser apagados (serão criados novamente de qualquer forma).
  * **Sintaxe Restrita:** O C# possui comandos mais diretos porém mais específicos que o Python, o que traz mais segurança e consistência para o código.
  * **Identidade do Projeto:** O C# não roda um algoritmo sem o arquivo de identidade (`.sln` ou `.csproj`), que especifica o tipo do código. Este projeto, por exemplo, é um algoritmo executável em console.
  * **.csproj vs .sln:** A diferença é que o `.csproj` cuida de apenas um projeto/algoritmo, enquanto a função do `.sln` é conectar múltiplos projetos que precisam trabalhar juntos. Se você tem 4 módulos para um site, por exemplo, você pode conectá-los em grupo com o `.sln` e usar o `.csproj` para especificar a função de cada um.
  * **Comandos CLI:** É mais fácil abrir o terminal (`Ctrl + '`) e usar `dotnet new console` para criar o `.csproj`.
  * Para a solução, o comando é mais específico: `dotnet new sln -n NomeDoProjeto` (onde `-n` define o nome).

  ---
  *Aprendendo linguagens diferentes com o mesmo algoritmo.*
</details>

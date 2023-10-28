<h1 align="center"> # Do.@-se App </h1>

<p align="center">
  <img width="460" height="250" src="./Imagens/doase.png">
</p>

<h2>1. Justificativa:</h2>

<p>
O presente projeto apresentado por meio deste repositório é a conclusão de um processo de idealização e desenvolvimento iniciado no segundo semestre de 2021 e concluído no fim do ano de 2023. Sua implementação serviu como <strong>método avaliativo para as disciplinas de Projeto Integrador de I a V, ministradas durante o curso tecnólogo de Análise e Desenvolvimento de Sistemas na instituição <a href="https://www.univag.com.br/curso/27/analise-e-desenvolvimento-de-sistemas/">UNIVAG (Universidade de Várzea Grande)</a>.</strong>
</p>

<h2>2. Título e descrição do projeto:</h2>

<p>
A solução Do.@-se foi pensada e criada para ser um aplicativo no qual pessoas e entidades poderiam interagir na forma de criação de campanhas sociais para arrecadação de bens e valores, a fim de que esta solução fosse contributiva para influenciar o Brasil na sua adequação às <a href="https://brasil.un.org/pt-br/sdgs" target="_blank">metas de desenvolvimento sustentável da ONU até 2030</a>, sobretudo no que diz respeito às metas de erradicação da probreza e fome zero.
</p>

<h2>3. Instruções de Instalação:</h2>

<p>
Para rodar o projeto em sua máquina, são necessários os seguintes pré-requisitos:
  
<ul>
    <li style="display: inline-block;">
        <strong>Requisito 1:</strong> Instalar o <a href="https://visualstudio.microsoft.com/pt-br/downloads/">Visual Studio 2022</a>
    </li>
     <li style="display: inline-block;">
        <strong>Requisito 2:</strong> Instalar a <a href="https://dotnet.microsoft.com/pt-br/download/dotnet/7.0">.NET Framework SDK 7.0.13 </a>
    </li>
</ul>

<p> Após as intalações necessárias, execute o projeto e, na aba de Ferramentas, na opção de Gerenciar Pacotes NuGet, o Visual Studio reconhecerá as bibliotecas necessárias para execução, instale-as conforme a imagem: </p>

![Dependências](./Imagens/Dependências.png)

<p> Concluídas as operações acima, já é possível rodar o projeto: </p>

<p align="center">
  <img width="320" height="480" src="./Imagens/Inicial.png" height= 100>
</p>

<p>Pronto! Agora é possível utilizar o aplicativo!</p>

<p><strong>As credenciais admin são:</strong></p>

<ul>
    <li style="display: inline-block;">
        <strong>Login:</strong> 1</a>
    </li>
     <li style="display: inline-block;">
        <strong>Senha:</strong> 1</a>
    </li>
</ul>

<h2>4. Documentações:</h2>

<p>Durante a idealização e planejamento do projeto foram elaboradas algumas documentações, aqui estão as principais: </p>

<ul>
    <li style="display: inline-block;">
        <strong><a href="https://www.dropbox.com/scl/fi/7zxchk2pype6ugh30idq3/Apresenta-o-30.11.pptx?rlkey=2x01irnkmydr276gg3rp1w4w1&dl=0">Apresentação em Power Point referente ao projeto de negócios, justificativas de mercado e ideias de implementações inciais</a></strong>
    </li>
      <li style="display: inline-block;">
        <strong><a href="https://www.dropbox.com/scl/fi/kd5i8a5c8063tnl0pqsf3/Documentacao_Doase_Projeto_V-1.pdf?rlkey=kochxxs4xaxevpk784le1pgf7&dl=0">Documento de requisitos, diagramas de casos de uso, funcionalidades e diagrama de banco de dados</a></strong>
    </li>
</ul>

<h2>5. Tecnologias: </h2>
<p>
Sobre o Aplicativo PWA

Nosso aplicativo PWA (Progressive Web App) foi desenvolvido utilizando um conjunto de tecnologias avançadas para proporcionar uma experiência de usuário eficiente e moderna. Este aplicativo combina a potência do C# e do .NET com a versatilidade do Blazor, Razor Pages e a arquitetura MVC para criar uma solução web robusta e flexível.

- **C# e .NET**: Utilizamos a linguagem de programação C# e a plataforma .NET para o desenvolvimento do back-end, permitindo um código seguro, eficiente e de alto desempenho.

- **Blazor e WebAssembly**: A estrutura Blazor nos permitiu criar interfaces de usuário dinâmicas e interativas usando C# e .NET, com a execução direta no navegador dos usuários, graças ao WebAssembly. Isso proporciona uma experiência de desenvolvimento mais produtiva e simplificada.

- **Razor Pages**: As Razor Pages são usadas para criar páginas da web de forma modular e reutilizável, facilitando o desenvolvimento e a manutenção do aplicativo, para estilização utilizamos a biblioteca <a href="https://getbootstrap.com">Bootstrap</a>.

- **Arquitetura MVC (Model-View-Controller)**: A arquitetura MVC é empregada para organizar o código e a lógica do aplicativo, tornando-o mais escalável e de fácil manutenção.

Além disso, incorporamos tecnologias web fundamentais, como JavaScript, CSS, HTML, para aprimorar a experiência do usuário e garantir que o aplicativo funcione perfeitamente em navegadores e dispositivos modernos.

</p>

<h2>6. Arquitetura: </h2>
<p>
  Nosso aplicativo segue a arquitetura MVC (Model-View-Controller) para organizar e estruturar o código de forma eficiente e escalável. A arquitetura MVC divide a aplicação em três componentes principais:

- **Model (Modelo)**: O Modelo representa a camada de dados da nossa aplicação. É responsável por gerenciar a lógica de negócios, a manipulação de dados e a comunicação com o banco de dados. No nosso caso, a pasta `.Shared` é usada para armazenar os modelos de dados e os repositórios, permitindo uma separação clara da camada de dados da lógica de negócios.

-  **View (Visualização)**: A Camada de Visualização é responsável pela apresentação e exibição de dados aos usuários. As páginas e estilizações do nosso aplicativo são armazenadas na pasta `.Client`, o que inclui as interfaces de usuário, os componentes Blazor e os recursos visuais que os usuários veem e interagem no navegador.

- **Controller (Controlador)**: O Controlador lida com a lógica de controle e atua como intermediário entre o Modelo e a Visualização. Nas páginas do nosso aplicativo, a pasta `.Server` contém as controllers responsáveis por receber solicitações do cliente, processar a lógica do servidor e retornar dados para a Visualização. Isso ajuda a manter a separação de responsabilidades e a garantir que a aplicação seja escalável.

Essa abordagem arquitetônica permite uma clara separação de preocupações e facilita a manutenção e a escalabilidade do nosso aplicativo. Os modelos no .Shared gerenciam os dados, as controllers no .Server controlam a lógica de negócios e as páginas e estilizações no .Client garantem uma experiência de usuário rica e responsiva.

</p>

<h2>7. Licença: </h2>
<p> 
Este software é distribuído sob os termos da Licença BSD (Berkeley Software Distribution).

**Licença BSD (Berkeley Software Distribution)**: A Licença BSD é uma licença de código aberto permissiva amplamente usada que permite que você use, modifique e distribua o código-fonte e o software, tanto em projetos comerciais quanto de código aberto. Ela é conhecida por sua simplicidade e flexibilidade. Esta licença requer que você dê créditos aos autores originais e inclua um aviso de direitos autorais ao redistribuir o software. Ela não impõe restrições significativas sobre o uso ou distribuição..
</p>



  
  

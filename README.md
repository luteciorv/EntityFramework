# EntityFramework
Uns 3 projetos embutidos sobre algumas formas de manipular banco de dados utilizando o Entity Framework

### Composição
> A solução apresenta 3 projetos:
> * CodeFirst: Onde é testado a metodologia do EntityFramework que o desenvolvedor programa as tabelas inicialmente e depois, através das Migrations, exporta
tais tabelas para o Banco de dados (nesse caso, SQLServer)

> * DatabaseCodeFirst: O processo inverso ao Code-First, onde já se tem as tabelas prontas no banco de dados e então o desenvolvedor importa elas para o seu programa,
onde será utilizado o Scaffolding para gerar arquivos de classes representando as tabelas

> * RelationshipBetweenObjects: Onde, por meio do Code-First, é adicionado chaves estrangeiras e relacionamento entre as classes (tabelas)

> A solução também tem os projetos conectados ao banco de dados local do SQLServer

### Teste por sí mesmo
Quando for executar um dos projetos acima, utilize a classe **Program.cs** e não se surpreenda com o console pacato que irá aparecer. Como o intuito dessa solução
era testar as funcionalidades do EntityFramework, não foi implementado nenhum corpo para o código, por assim dizer. Portanto abra o banco de dados, altere valores 
e manuseie da forma que desejar

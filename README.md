<b>Considerações</b>
<br/><br/>
Encapsulei todas as propriedades com o intuito de controlar o acesso e realizar a validação das mesmas dentro do "set" mas não enxerguei na descrição do problema nenhuma validação necessária.

Nos testes unitários, utilizei a função AreEquals, porém, como a mesma considera objetos como diferentes mesmo eles tendo todas as suas propriedades iguais (===), e para evitar ter de comparar propriedade por propriedade, sobrescreví o método ToString colocando as informações pertinentes ao caso de teste na saída do mesmo e o utilizei como parâmetro de comparação.

Pensei em utilizar o método "ShouldBeEquivalentTo" disponível no pacote NuGet "FluentAssertions" mas considerei mais interessante não utilizar fontes externas.
<br/><br/><br/>
<b>Descrição do problema:</b>

Assuma um plano cartesiano de coordenadas X x Y. 
Assumindo uma posição original (x,y), a aplicação irá receber vetores de coordenadas na seguinte forma: 

[Direção, Intensidade], sendo que Direção pode ser N,S,L,O (Norte, Sul, Leste e Oeste) e intensidade é um inteiro. 

Exemplo: Digamos que nosso ponto atual é (1,1) e recebe um vetor [N,10], ele precisa parar na posição (1,11). Se após isso a aplicação receber o vetor [L,5], a posição atual deve ser (6,11). 
<br/><br/><br/>
<b>Casos de Teste</b>

1) Assuma como ponto de partida (8,12). Após receber os vetores abaixo, a aplicação deve exibir a posição (34,10).

    
    a. [N,23] (8,35)
    
    b. [O,7] (1,35)
    
    c. [S,40] (1,-5)
    
    d. [L,33] (34,-5)
    
    e. [N,15] (34,10)


2) Assuma como ponto de partida (-10,0). Após receber os vetores abaixo, a aplicação deve exibir a posição (-14,7).

    a. [L,14] (4,0)
    
    b. [N,27] (4,27)
    
    c. [O,33] (-29,27)
    
    d. [S,20] (-29,7)
    
    e. [L,15] (-14,7)

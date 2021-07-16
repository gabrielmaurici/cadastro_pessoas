# cadastro_pessoas
Atividade com Classes Heranças para ProWay - Havan Labs


1 - Defina POO: É uma forma de abstrair a realidade para dentro da programação, através da criação e interação de objetos, facilitando na organização e formação do código, fazendo com que ele seja divido em várias partes importantes e mais compactas.

2 - Defina Classe: Classe é uma forma de deifinir um objeto, como por exemplo uma classe Pessoa, é possível atribuir algumas variaveis a essa classe, 'string nome, int idade' etc...

3 - Defina Método: É uma 'função' que pode ser chamada para executar um bloco de instruções criadas pelo programador.

4 - Defina Herança: Herança é uma forma de atribuir os mesmos objetos a classes parecidas.

	EXEMPLO HERANÇAS
	
	Classe Produto e Classe Categoria

	As duas classes vão possuir ID e NOME, porém, produto irá conter uma variável VALOR e categoria irá conter uma variável DESCRIÇÃO, então é possível criar uma classe Base com ID e NOME que será herdada nas classes Produto e Categoria para que elas possuam ID e NOME, tendo a necessidade de criar apenas mais uma propriedade VALOR para Produto e DESCRIÇÃO para Categoria.

5 - Defina Composição: Composição é uma forma de somar 2 classes que 'dependem' uma da outra, por exemplo, um produto contém uma categoria, porém, categoria é diferente de produto, mas para cadastrar um produto é importante ter definido uma categoria para esse produto. Dessa forma é possível fazer uma composição da classe Categoria dentro da classe Produto, para que sejam coisas distintas, mas que fazem parte uma da outra.

6 - Diferença de parâmetro e argumento: Parâmetro é uma forma de referenciar variáveis, então podemos receber valores para um objeto atráves de parâmetros definidos em um método, e Arguemtos são os valores definidos que irão ser enviados para o parâmetro.

7 - Sobrecarga de métodos: A sobrecarga de métodos é uma forma de acessar blocos de intruções diferentes.
	 
	EXEMPLO: É possível ter dois métodos com o mesmo nome, um que recebe uma string e outro que recebe um inteiro, e dependendo do parâmetro que esse método recebe, ele executa o bloco de instruções definido pelo método e parâmetro recebido. Então se você envia uma string, o método que contém a string como parâmetro executa uma instrução, mas se você usar o método enviando um inteiro, esse método que recebe um int executa outro tipo de instrução.

8 - Parâmetros Opcionais: São parâmetros definidos com algum valor Padrão, assim os parâmetros padrões devem ser definidos nas posições finais, e se não preenchidos, continuam com seu valor padrão, tornando o parâmetro opcional.

9 - Parâmetros Nomeados: São parâmetros que são identificados por nomes mais didáticos.
		
	EXEMPLO: public void Pessoa(nome: "Gabriel", dataNascimento: 1999-03-08);
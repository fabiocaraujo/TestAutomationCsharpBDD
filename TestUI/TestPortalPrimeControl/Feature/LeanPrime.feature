  #language: pt
  Funcionalidade: Preencher Formulário Lean
  Como usuário da Pagina Prime Control
  Quero preencher o formulário
  Para receber gratuitamente o White Paper
  
  @web
  Esquema do Cenário: Preenchimento válido
  Dado que eu navegue até a pagina do formulário Lean
  Quando eu preencher os campos "Nome", "Sobrenome", "Cargo","Uf","Empresa","Email"
  Então deve exibir uma mensagem: "Estamos preparando seu download. Ele será enviado para seu e-mail."
  E direcionar um email com o White Paper
  
  Exemplo: 
      | Nome  | Sobrenome | Cargo    | Uf | Empresa | Email                     | 
      | Fabio | Araujo    | Analista | SP | Prime   | fabio.araujo@prime.com.br | 
      | Ana   | Silva     | Gerente  | RJ | Itau    | ana.silva@itau.com.br     | 
  
  @web
  Esquema do Cenário: Preenchimento inválido
  Dado que eu navegue até a pagina do formulário Lean
  Quando eu preencher com dados inválidos os campos "Nome", "Sobrenome", "Cargo","Uf","Empresa","Email"
  Então deve exibir uma mensagem de erro
  
  Exemplo: 
      | Nome  | Sobrenome | Cargo    | Uf | Empresa | Email        | 
      | Fabio |           | Analista | SP | Prime   | fabio.araujo | 
      | Ana   | Silva     | Gerente  |    | Itau    | itau.com.br  | 
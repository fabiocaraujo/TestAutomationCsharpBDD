  #language: pt
  Funcionalidade: Validar elementos da Home
  Como usuário da Pagina Prime Control
  Quero navegar na home 
  Para certificar que os elementos estejam na tela
  
  @web
  Cenário: Validar Pagina Inicial
  Dado que navegue para a home
  Então deve validar elementos da tela inicial 
  
  @web
  Cenário: Validar Menu quem somos
  Dado que navegue para a home
  Quando clicar no menu Quem Somos
  Então deve direcionar para a pagina Quem somos
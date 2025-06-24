Desenvolvi um sistema de boletim escolar. Cada estudante possui duas notas, e a situação final (“Aprovado” ou “Reprovado”) não deve ser inserida manualmente. Em vez disso, a situação deve ser calculada automaticamente com base na média das duas notas.

Criei uma classe Estudante, com:

Propriedade pública Nome
Propriedades públicas Nota1 e Nota2, ambas com get e set
Propriedade pública somente leitura Media
Propriedade pública somente leitura Situacao, que retorna:
"Aprovado" se a média for maior ou igual a 6
"Reprovado" se for menor

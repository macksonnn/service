CREATE TABLE IF NOT EXISTS Cartao(
IdCartao int AUTO_INCREMENT PRIMARY KEY,
NumeroCartao varchar(30),
DataValidade Date,
CVV varchar(3),
Bandeira varchar(30),
Nome varchar(100)
);


CREATE TABLE IF NOT EXISTS Saldo(
IdSaldo int AUTO_INCREMENT PRIMARY KEY,
SaldoDotz DECIMAL(10,2),
SaldoReais DECIMAL(10,2),
DataSaldo Date
);
  
  

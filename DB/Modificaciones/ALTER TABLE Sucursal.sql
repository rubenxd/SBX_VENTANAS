ALTER TABLE Sucursal
ADD Cliente INT

ALTER TABLE Sucursal
ADD FOREIGN KEY (Cliente) REFERENCES Cliente(Codigo);
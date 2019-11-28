namespace ExercicioBanco {
    class ContaBanco {

        private string _nome;
        public int Conta { get; private set; }
        public int Agencia { get; private set; }
        public double _saldo;

        public string Nome {
            get { return _nome; }
            set {
                if (value != null) {
                    _nome = value;
                }
            }
        }

        public double Saldo {
            get { return _saldo; }
        }
        public double Deposito {
            set {
                _saldo += value; 
            }
        }

        public double Saque {
            set {
                _saldo -= value + 5.0;
            }
        }

        public ContaBanco(string nome, int conta, int agencia) {
            _nome = nome;
            Conta = conta;
            Agencia = agencia;
            _saldo = 0;
        }

        public ContaBanco(string nome, int conta, int agencia, double saldo) : this(nome, conta, agencia) {
            _nome = nome;
            Conta = conta;
            Agencia = agencia;
            _saldo = saldo;
        }


        public override string ToString() {
            return "Titular: " + _nome
                    + ", Conta: " + Conta
                    + ", Agencia: " + Agencia
                    + ", Saldo: R$ " + _saldo.ToString("F2");
        }


    }
        
}


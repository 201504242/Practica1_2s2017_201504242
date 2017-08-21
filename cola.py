import pila
class Nodo():
    def __init__(self, pre,operaciones):
        self.operaciones = operaciones
        self.siguiente = None
        self.postorden = operaciones
        self.pre = pre
class Cola():
    def __init__(self):
        self.primero = None
        self.tama = 0
    def add(self,operaciones):
        pre = operaciones
        operaciones = self.cambioOrden(operaciones)
        nuevoNodo = Nodo(pre,operaciones)
        if self.primero is None:
            self.primero = nuevoNodo
        else:
            actual = self.primero
            while(actual.siguiente != None):
                actual = actual.siguiente
            actual.siguiente = nuevoNodo
        self.tama = self.tama+1
        print("Agregado a la cola: "+operaciones)

    def mostrarCola(self):
        if self.primero != None:
            aux = self.primero
            cont = 0
            while(aux != None):
                print("indice "+str(cont)+": "+str(aux.operaciones))
                aux = aux.siguiente
                cont = cont + 1


    def pop(self):
        if self.primero != None:
            auxiliar = self.primero
            self.primero = self.primero.siguiente
            self.tama = self.tama - 1
            return auxiliar.operaciones
        return "COLA VACIA"

    def pre(self):
        if self.primero != None:
            auxiliar = self.primero
            return auxiliar.pre
    def depurador(self,cadenaInorden):
        cadena = cadenaInorden
        concat = ""
        for x in cadena:
            if '+' in x:
                concat = concat + " " + x + " "
            elif '(' in x:
                concat = concat + " " + x + " "
            elif ')' in x:
                concat = concat + " " + x + " "
            elif '-' in x:
                concat = concat + " " + x + " "
            elif '*' in x:
                concat = concat + " " + x + " "
            elif '/' in x:
                concat = concat + " " + x + " "
            elif '^' in x:
                concat = concat + " " + x + " "
            else:
                concat = concat + x
        concat = concat.split()
        return concat

    def operadores(self, ope):
        if ope == "+":
            return 1
        elif ope == "-":
            return 1
        elif ope == "*":
            return 1
        elif ope == "/":
            return 1
        elif ope == "(":
            return 2
        elif ope == ")":
            return 3
        else:
            return False

    def pref(self,op):
        prf = 99
        if op == "+" or op == "-": prf =3
        if op == "*" or op == "/": prf = 4
        if op == "^" : prf = 5
        if op == "(": prf = 1
        if op == ")": prf = 2
        return prf

    def cambioOrden(self,inorden):

        P = pila.Pila()
        S = pila.Pila()
        inorden = self.depurador(inorden) #arraglo valores
        try:
            for x in range(0,inorden.__len__()):
                actual = inorden[x]
                if self.operadores(actual)==1: #1 para operador
                    if P.isEmpty():
                        P.add(actual)
                    else:
                        cimaP = P.peek()
                        if self.pref(cimaP) < self.pref(actual):
                            P.add(actual)
                        else:
                            aux = []
                            cond1 = self.pref(cimaP) >= self.pref(actual)
                            cond2= not(cimaP =="(")
                        #    cond3=  not(P.isEmpty())
                            while( cond1 or cond2):
                                aux.append(P.pop())
                                cimaP = P.peek()
                                cond1 = self.pref(cimaP) >= self.pref(actual)
                                cond2 = not (cimaP == "(")
                                cond3 = not (P.isEmpty())
                            P.add(actual)
                            for a in aux:
                                S.add(a)
                   # print actual
                elif self.operadores(actual)==2:#2 para (
                    P.add(actual)
                elif self.operadores(actual)==3:#3 para )
                    while(P.peek() != "("):
                        S.add(P.pop())
                    P.pop()
                else:
                    S.add(actual)
                    #print actual
           # print "-------POSTFIJA-------"
            pos=""
            for x in range(0,S.tama):
                pos=  S.pop() +" "+pos
            return pos
        except Exception:
            print "Error en la EXPRESION ALGEBRAICA"
            print Exception.message
            return "(0)"

if __name__ == '__main__':
    var = Cola()
    var.add("((8 / 3) * 7 + (7 * (6 + 1)))")

    #print str(var.pre())

    pilita = pila.Pila()
    print pilita.calcular(var.pop())

    #var.add("15 20 +")
    #var.add("2 3 5 - *")
    #var.add("2 8 + 4 * 7 -")
    #var.add("27 24 - 7 4 + *")
    #print("tama: "+str(var.tama))
    #print(var.pop())
    #print("tama: " + str(var.tama))

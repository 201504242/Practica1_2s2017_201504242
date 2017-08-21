import cola

class Nodo():
    def __init__(self, operaciones):
        self.operaciones = operaciones
        self.anterior = None

class Pila():
    def __init__(self):
        self.primero = None
        self.ultimo = None
        self.tama = 0
        self.cadenaRes = ""
    def calcular(self,ino):
       # operacion = self.cambioOrden(ino)
        espacios = ino.split()
        total=0
        # AGREGAR TODOS LOS NUMEROS HASTA ENCONTRAR SIMBOLO
        for x in range(0, espacios.__len__()):

            self.add(espacios[x])
            self.cadenaRes = self.cadenaRes + "push("+espacios[x]+")\n"
            if espacios[x] is "+":
                self.cadenaRes = self.cadenaRes +"pop() = " +self.pop() + "\n"
                primero = self.pop()
                segundo = self.pop()
                total = int(primero) + int(segundo)
                #print (str(primero) + " + " + str(segundo) + " = " + str(total))
                self.cadenaRes = self.cadenaRes + str(primero) + " + " +str(segundo )+ " = "+str(total )+"\n"
                self.add(total)
                self.cadenaRes = self.cadenaRes + "push("+str(total)+")\n"
            elif espacios[x] is "-":
               # print("saca: " + self.pop())
                self.cadenaRes = self.cadenaRes + "pop() = " + self.pop() + "\n"
                primero = self.pop()
                segundo = self.pop()
                total = int(segundo) - int(primero)
                #print (str(primero) + " - " + str(segundo) + " = " + str(total))
                self.cadenaRes = self.cadenaRes + str(primero) + " - " + str(segundo) + " = " + str(total) + "\n"
                self.add(total)
                self.cadenaRes = self.cadenaRes + "push(" + str(total) + ")\n"

            elif espacios[x] is "*":
                #print("saca: " + self.pop())
                self.cadenaRes = self.cadenaRes + "pop() = " + self.pop() + "\n"
                primero = self.pop()
                segundo = self.pop()
                total = int(primero) * int(segundo)
                #print (str(primero) + " * " + str(segundo) + " = " + str(total))
                self.cadenaRes = self.cadenaRes + str(primero) + " * " + str(segundo) + " = " + str(total) + "\n"
                self.add(total)
                self.cadenaRes = self.cadenaRes + "push("+str(total)+")\n"

        return str(self.cadenaRes.strip())+","+str(total)

    def add(self,dato):
        nuevo = Nodo(dato)
        if self.primero is None:
            self.primero = nuevo
            self.ultimo = nuevo
        else:
            actual = self.ultimo
            while(actual.anterior != None):
                actual = actual.anterior
            actual.anterior = nuevo
            self.primero = nuevo
        self.tama = self.tama + 1

    def isEmpty(self):
        if self.primero is None and self.ultimo is None or self.tama==0:
            return True
        else:
            return False

    def peek(self):
        if  self.primero is not None:
            return self.primero.operaciones
        else:
            return ""

    def pop(self):
        actual = self.ultimo
        anterior = self.ultimo
        if actual is not None and anterior is not None: #Pila NO Vacia
            if self.ultimo == self.primero:
                retornado = self.primero.operaciones
                self.ultimo = None
                self.primero = None
            else:
                while(actual.anterior != None):
                    anterior = actual
                    actual = actual.anterior
                retornado = self.primero.operaciones
                anterior.anterior = None
                self.primero = anterior
            self.tama = self.tama - 1
        else:
            retornado= ""
        return retornado

    def pref(self,op):
        prf = 99
        if op == "+" or op == "-": prf =3
        if op == "*" or op == "/": prf = 4
        if op == "^" : prf = 5
        if op == "(": prf = 1
        if op == ")": prf = 2
        return prf

    def cambioOrden(self,inorden):

        P = Pila()
        S = Pila()
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
            #print "-------POSTFIJA-------"
            pos=""
            for x in range(0,S.tama):
                pos=  S.pop() +" "+pos
            return pos
        except Exception:
            print "Error en la EXPRESION ALGEBRAICA"
            print Exception.message
            return "(0)"

    def operadores(self,ope):
        if ope == "+": return 1
        elif ope == "-": return 1
        elif ope == "*": return 1
        elif ope == "/": return 1
        elif ope == "(": return 2
        elif ope == ")": return 3
        else: return False

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

if __name__ == '__main__':
    var = Pila()
   # var.calcular("2 5 + 3 * 2 +")
    #var.calcular("3 1 + 8 3 * 2 - +")
    #post = var.cambioOrden("(2*(23+6)-1)")
    print var.calcular("((2 + 8) * 7 + (7 * (6 + 1))))")

    #print(var.pop())

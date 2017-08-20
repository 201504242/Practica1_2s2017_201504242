class Nodo():
    def __init__(self, operaciones):
        self.operaciones = operaciones
        self.anterior = None
class Pila():
    def __init__(self):
        self.primero = None
        self.ultimo = None
        self.cadena = ""

    def calcular(self,operacion):
        espacios = operacion.split()
        total=0
        # AGREGAR TODOS LOS NUMEROS HASTA ENCONTRAR SIMBOLO
        for x in range(0, espacios.__len__()):

            self.add(espacios[x])
            if espacios[x] is "+":
                print("saca: " + self.pop())
                primero = self.pop()
                segundo = self.pop()
                total = int(primero) + int(segundo)
                print (str(primero) + " + " + str(segundo) + " = " + str(total))

                self.add(total)

            elif espacios[x] is "-":
                print("saca: " + self.pop())
                primero = self.pop()
                segundo = self.pop()
                total = int(segundo) - int(primero)
                print (str(primero) + " - " + str(segundo) + " = " + str(total))

                self.add(total)
            elif espacios[x] is "*":
                print("saca: " + self.pop())
                primero = self.pop()
                segundo = self.pop()
                total = int(primero) * int(segundo)
                print (str(primero) + " * " + str(segundo) + " = " + str(total))

                self.add(total)
        print total



    def add(self,dato):
        nuevo = Nodo(dato)
        if self.primero is None:
            self.primero = self.ultimo = nuevo
        else:
            actual = self.ultimo
            while(actual.anterior != None):
                actual = actual.anterior
            actual.anterior = nuevo
            self.primero = nuevo

    def pop(self):
        actual = self.ultimo
        anterior = self.ultimo
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
        return retornado

    def cambioOrden(self,inorden):
        return self.ayudanteCambio(inorden)

    def ayudanteCambio(self,inorden):

        for x in range(1, inorden.__len__()-1):
            print inorden[x]
            if  inorden[x] == "+":
                num1 = inorden[x-1]
                num2 = inorden[x+1]
                self.cadena = self.cadena + " "+ num1 + " " + num2 + " + "

        return self.cadena

if __name__ == '__main__':
    var = Pila()
    #print(var.calcular("2 5 + 3 * 1 +"))
    print(var.cambioOrden("(2+8+4)"))

    #print(var.pop())

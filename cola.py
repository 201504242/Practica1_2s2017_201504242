class Nodo():
    def __init__(self, operaciones):
        self.operaciones = operaciones
        self.siguiente = None

class Cola():
    def __init__(self):
        self.primero = None
        self.tama = 0

    def add(self,operaciones):
        nuevoNodo = Nodo(operaciones)
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

if __name__ == '__main__':
    var = Cola()
    var.add("15 20 +")
    var.add("2 3 5 - *")
    var.add("2 8 + 4 * 7 -")
    var.add("27 24 - 7 4 + *")
    print("tama: "+str(var.tama))
    print(var.pop())
    print("tama: " + str(var.tama))

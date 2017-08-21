import cola

class Nodo():
    def __init__(self,ip,mascara):
        self.indice = 0
        self.ip = ip
        self.estado = False
        self.mascara = mascara
        self.carnet = ""
        self.siguiente = None
        self.mensajes = cola.Cola()

class Lista():
    def __init__(self):
        self.primero = None
        self.length = 0
        self.cont =0
        self.ipServidor = "192.168.0.1"
        self.mascaraServidor = "255.255.255.0"

    def insertar(self, ip,mascara):
        nuevo = Nodo(ip,mascara)
        self.cont = self.cont + 1
        nuevo.indice = self.cont
        if self.primero == None:
            self.primero = nuevo
        else:
            auxiliar = self.primero
            while auxiliar != None:
                if auxiliar.siguiente == None:
                    break
                auxiliar = auxiliar.siguiente
            auxiliar.siguiente = nuevo
        self.length = self.length + 1

    def buscar(self, ip):
        auxiliar = self.primero
        while auxiliar != None:
            if auxiliar.ip == ip:
                return auxiliar
            auxiliar = auxiliar.siguiente
        return None

    def eliminar(self, valor):
        print("valor entrante: " + valor)
        if valor is None:
            self.primero = self.primero.siguiente
        else:
            auxiliar = self.primero
            while auxiliar != None:
                if auxiliar.siguiente.ip == str(valor):
                    auxiliar2 = auxiliar.siguiente
                    auxiliar.siguiente = auxiliar2.siguiente
                    auxiliar2.siguiente = None
                    break
                auxiliar = auxiliar.siguiente
        print("Eliminado valor")

    def listarNodos(self):
        aux = self.primero
        arreglos = ""
        while aux != None:
            arreglos = arreglos+"," +str(aux.indice)+","+ str(aux.ip) + "," + str(aux.mascara) + "," + str(aux.estado)
            aux = aux.siguiente
        return arreglos

    def report(self):
        coladot = open("lista.dot", "w")
        auxiliar = self.primero
        cadena = "rankdir=LR; \n node [shape=box];"
        apuntadores = ""
        while auxiliar != None:
            cadena = cadena + "\n" + str(auxiliar.indice) + "[label=\"" + str(auxiliar.ip) + "\"];"
            if auxiliar.siguiente != None:
                apuntadores = apuntadores + "\n" + str(auxiliar.indice) + " -> " + str(
                    auxiliar.siguiente.indice) + ";"
            auxiliar = auxiliar.siguiente

        coladot.write("digraph G { \n" + cadena + "\n" + apuntadores + "\n }")
        coladot.close()

if __name__ =="__main__":
    var = Lista()
    var.insertar("192.168.0.1" ,"255.255.255.0")
    var.insertar("192.168.0.2" , "255.255.255.0")
    var.insertar("192.168.0.3" , "255.255.255.48")
    var.insertar("192.168.0.4" , "255.255.255.0")
    nodo = var.buscar("192.168.0.3")
    print nodo.mascara
    var.insertar("192.168.0.5","153")
    print var.listarNodos()
    var.report()
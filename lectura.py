import json

from pprint import pprint

class lectura():
    def __init__(self):
        self.local = "192.168.0.1"
        self.mascara = "255.255.255.0"

    def leerJSON(self):
        leer = json.loads(open('C:\Users\p_ab1\Desktop\eje.json').read())
        print leer
        print leer['nodos']['nodo'][2]
        print "---"

        with open('C:\Users\p_ab1\Desktop\eje.json') as fa:
            lineas = 0
            for line in fa:
                lineas = lineas + 1

                print line
            #pprint(data)

if __name__ == "__main__":
    a = lectura()
    a.leerJSON()
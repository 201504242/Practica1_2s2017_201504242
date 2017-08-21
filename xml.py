
from xml.dom.minidom import parse

datasource = open('C:\\Users\\p_ab1\\Desktop\\mensaje.xml')
doc = parse(datasource)
s = doc.getElementsByTagName("mensaje")
cadena = ""
for mensaje in s:
    texto = str(mensaje.getElementsByTagName("texto")[0].firstChild.data).strip()
    print texto
    ips = mensaje.getElementsByTagName("IP")
    for ip in ips:
        cadena = str(ip.firstChild.data).strip()
        cadena = cadena.strip()
        print cadena

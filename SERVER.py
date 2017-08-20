from flask import Flask, request, Response
app = Flask("EDD_codigo_ejemplo")
import lista
import json

import os
listadoIP = lista.Lista()

@app.route("/")
def hell():
	return "Hello!"

def shutdown_server():
    func = request.environ.get('werkzeug.server.shutdown')
    if func is None:
        raise RuntimeError('Not running with the Werkzeug Server')
    func()

@app.route('/shutdown')
def shutdown():
    shutdown_server()
    return 'Server shutting down...'

@app.route("/ipServidor")
def ipServidor():
    return listadoIP.ipServidor

@app.route("/prueba",methods=['POST'])
def prueba():
    data = str(request.form['data'])
    hola = int(request.form['hola'])
    return "mando: "+data+" int("+str(hola)+")"

@app.route("/listarNodos",methods=['POST'])
def listarNodos():
    return listadoIP.listarNodos()

@app.route("/cambiarIP",methods=['POST'])
def cambiarIP():
    try:
        os.system('netsh interface ip set address name="Wi-Fi" source=static addr=' + str(listadoIP.ipServidor) + ' mask=' + str(listadoIP.mascaraServidor) + ' gateway=192.168.0.33 store=persistent')
        #shutdown_server() #AQUI SE APAGA EL SERVIDOR
        return "True"
    except:
        return "error"

@app.route("/leerJSON",methods=['POST']) #INSERTA DATOS
def leerJSON():
    ubicacion = str(request.form['ubicacion'])
    leer = json.loads(open(ubicacion).read())
    listadoIP.ipServidor = str(leer['nodos']['local'])
    listadoIP.mascaraServidor = str(leer['nodos']['mascara'])
    lista = leer['nodos']['nodo']
    for x in lista:
        listadoIP.insertar(str(x['ip']),str(x['mascara']))
    # SE ASINA LA IP Y LA MASCARA DE SUBRED A LA COMPUTADORA
    try:
        return listadoIP.ipServidor #RETORNA LA IP DEL SERVIDOR
    except:
        return "False"



if __name__ == "__main__":
    app.run(debug=True, host='0.0.0.0')
    #app.run(debug=True)
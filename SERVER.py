from flask import Flask, request, Response
app = Flask("EDD_codigo_ejemplo")

@app.route("/")
def hell():
	return "Hello!"

if __name__ == "__main__":
  app.run(debug=True)
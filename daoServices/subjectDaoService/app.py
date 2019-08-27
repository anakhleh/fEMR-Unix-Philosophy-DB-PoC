from flask import Flask
from flask_sandboy import Sandboy
from flask_sqlalchemy import SQLAlchemy
import os
# from models import Machine, Cloud,


app = Flask(__name__)
app.config['SQLALCHEMY_DATABASE_URI'] = os.environ['DB_CONNECTION_STR']
db = SQLAlchemy(app)

########## Define Models #######################################################
class Subject(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(50), nullable=False)

    def __repr__(self):
        return self.name

################################################################################

db.init_app(app)
with app.app_context():
    db.create_all()
sandboy = Sandboy(app, db, [Subject])
app.run(debug=True)
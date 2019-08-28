# import logging
from flask import Flask
from flask_appbuilder import AppBuilder, SQLA

# logging.basicConfig(format="%(asctime)s:%(levelname)s:%(name)s:%(message)s")
# logging.getLogger().setLevel(logging.DEBUG)

app = Flask(__name__)
app.config.from_pyfile("../config.py")
db = SQLA(app)
appbuilder = AppBuilder(app, db.session)

from . import models, api  # noqa

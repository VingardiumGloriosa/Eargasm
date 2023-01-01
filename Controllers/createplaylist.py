"""
import os
import re

import spotipy
from spotipy.oauth2 import SpotifyClientCredentials
"""
import numpy as np
#import matplotlib.pyplot as plt
import pandas as pd
from sklearn.preprocessing import MinMaxScaler
from numpy.core.fromnumeric import shape
from keras.models import Sequential
from keras.layers import Dense, LSTM, Dropout
from tensorflow.keras.optimizers import Adam
from tensorflow import keras
import spotipy
from spotipy.oauth2 import SpotifyClientCredentials

CLIENT_ID = '7d14d7a75a87422d98c2cbbdce52d31e'
CLIENT_SECRET = '0fde8d452c0a4fc8908a8f379f12fb27'
username = "21n37prne5zlleh5pxfkpgspq"
model = keras.models.load_model(
    r'C:\Users\Glória\Code\GitHub\Sem 4\CryingMaterial\Eargasm\Controllers\acousticnesshandpicked.h5')
source = r"C:\Users\Glória\Code\GitHub\Sem 4\CryingMaterial\Eargasm\testfunctionality.csv"
newPlaylist = []
playlistDict = {}
sortedPlaylistName = "sortedtest"

dataset_train = pd.read_csv(source)
originalPlaylist = dataset_train.iloc[:, 1:2]
training_set = dataset_train.iloc[:, 7:8].values  # return numpy arr
print(dataset_train.iloc[:5, 7:8])  # works in terminal
working_set = dataset_train.iloc[:5, 7:8]
"""
sc = MinMaxScaler(feature_range=(0,1)) # scales input to values between 0.0 and 1.0
training_set_scaled = sc.fit_transform(training_set)
working_set_scaled = sc.fit_transform(working_set)
print(working_set_scaled)
#print(training_set_scaled)
"""
# new authentication for user (used to be just session but to do shit with users we need to authenticate them specifically)
# this is also better authentication in general as it allows for more options while authenticating like speciffic scopes, redirects, etc.
token = spotipy.util.prompt_for_user_token(
    username=username,
    scope='playlist-modify-public playlist-modify-private',
    client_id=CLIENT_ID,
    client_secret=CLIENT_SECRET,
    redirect_uri="http://localhost:5123/callback"
)
sp = spotipy.Spotify(auth=token)

#user_playlist_create(user, name, public=True, collaborative=False, description='')
sp.user_playlist_create(username, sortedPlaylistName)
playlists = sp.user_playlists(username)["items"]

for playlist in playlists:
    playlistName = playlist["name"]
    playlistID = playlist["id"]
    playlistDict[playlistName] = playlistID

print(playlistDict[sortedPlaylistName])

"""
prediction = model.predict(working_set)
print(prediction[4])

#prediction = 0.6

idx = (np.abs(training_set - prediction[4])).argmin()
playlist = (idx)

temp = np.append(working_set, [training_set[idx]], axis = 0)
working_set_scaled = temp[1:]
print(working_set_scaled)
"""
"""
prediction = model.predict(working_set)
idx = (np.abs(training_set - prediction[4])).argmin()
print(np.int64(idx).item())
temp = np.append(working_set, [training_set[idx]], axis = 0)
#tempidx = np.int64(idx).item()
working_set = temp[1:]
newPlaylist = [originalPlaylist.iloc[idx]["id"]]
print(type(newPlaylist))
print(newPlaylist)
training_set = np.delete(training_set, idx, axis=0)
#print(working_set)
print(originalPlaylist.iloc[idx]["id"])
"""
for i in range(training_set.size - 6):
    prediction = model.predict(working_set)
    print(prediction)
    idx = (np.abs(training_set - prediction[4])).argmin()
    print(np.int64(idx).item())
    temp = np.append(working_set, [training_set[idx]], axis=0)
    working_set = temp[1:]
    newPlaylist.append(originalPlaylist.iloc[idx]["id"])
    training_set = np.delete(training_set, idx, axis=0)
    # print(working_set)

print(newPlaylist)
#user_playlist_add_tracks(user, playlist_id, tracks, position=None)
sp.user_playlist_add_tracks(
    username, playlistDict[sortedPlaylistName], newPlaylist, position=None)

#user_playlist_create(user, name, public=True, collaborative=False, description='')
#sp.user_playlist_create(username, "sorted")

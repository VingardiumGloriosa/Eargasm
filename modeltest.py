import numpy as np
#import matplotlib.pyplot as plt
import pandas as pd
from sklearn.preprocessing import MinMaxScaler
from numpy.core.fromnumeric import shape
from keras.models import Sequential
from keras.layers import Dense, LSTM, Dropout
from tensorflow.keras.optimizers import Adam

#set constants for future tweaking
# parameters
days = 60 # how many days to look back, when predicting price movement
lookAhead = 15 # predict price, after this many days
dropRate = 0.2 # drop 20% of neurons to prevent overfitting
units_ = 30 # number of neurons
learningRate = 0.001
batchSize = 8
epochs_ = 5

#Get training data from file. Convert from Pandas datafram to Numpy array.
# import training set
dataset_train = pd.read_csv('traindanceability.csv')
training_set = dataset_train.iloc[:,2:3].values # return numpy arr
print(dataset_train.iloc[0:5,2:3]) #works in terminal

sc = MinMaxScaler(feature_range=(0,1)) # scales input to values between 0.0 and 1.0
training_set_scaled = sc.fit_transform(training_set)

#Create X_train and y_train from the scaled data in step 5.
# Create a datastructure with x number of timesteps and 1 output.
# Important question: how many days to look back ? 10,20... ?

X_train = []
y_train = []
for i in range(days,300 - lookAhead):
  X_train.append(training_set_scaled[i-days:i,0]) # why specify column=0?
  if training_set[i-days+lookAhead,0] - training_set[i-days,0] > 0:
    y_train.append(1)
  else:
    y_train.append(0)
# X_train and y_train are lists. Need to be cast to numpy arrays
X_train, y_train = np.array(X_train), np.array(y_train)

#Reshape array from 2D to 3D, to enable other data to be added later, if necessary
X_train = np.reshape(X_train, (X_train.shape[0], X_train.shape[1], 1)) # add one more dimension, so we go from
# (rows_, cols_) to (rows_, cols_, 1). The last 1 can be replaced with 2,3,4 etc. if you have more data, 
#f.x. trading volume, high/low etc.


model = Sequential()

# add the first LSTM layer and Dropout regularization
model.add(LSTM(units=units_, return_sequences=True, input_shape=(X_train.shape[1], 1)))
# The input_shape of LSTM has this format: (num_timesteps, num_features)
# num_timesteps set the number columns 
# In this case, we get the number of timesteps from X_train.shape[1], since it returns the  number of columns
# The second argument, num_features
# Amount of rows is given by the


# use return_sequences to indicate, that another LSTM is coming afterwards
model.add(Dropout(rate=dropRate)) # for each iteration, ignore 20% of the neurons from previous layer.
# It makes the model more sparse (less dense), which forces it to learn even without some neurons.
# This in turn makes the model more robust when predicting unseen new data!

model.add(LSTM(units=units_, return_sequences=True)) # 2nd layer
model.add(Dropout(rate=dropRate))

model.add(LSTM(units=units_, return_sequences=True)) # 3rd layer
model.add(Dropout(rate=dropRate))

model.add(LSTM(units=units_, return_sequences=True)) # 4th layer
model.add(Dropout(rate=dropRate))

model.add(LSTM(units=units_, return_sequences=False)) 
model.add(Dropout(rate=dropRate))

model.add(Dense(1, activation="sigmoid"))

adam = Adam(learning_rate=learningRate)
model.compile(optimizer=adam,loss="binary_crossentropy", metrics=['accuracy'])


model.fit(X_train, y_train, batch_size=batchSize, epochs = epochs_, verbose=1) 

# you should get accuracy > 50%. For the Google Stock Price I have reached ~72% accuracy
#test data normalization
dataset_test = pd.read_csv('testdanceability.csv')
testing_set = dataset_test.iloc[:,2:3].values # return numpy arr

sc = MinMaxScaler(feature_range=(0,1)) # scales input to values between 0.0 and 1.0
testing_set_scaled = sc.fit_transform(testing_set)

model.predict(testing_set_scaled)
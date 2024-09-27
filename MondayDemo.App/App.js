import { StatusBar } from 'expo-status-bar';
import { useState } from 'react';
import { StyleSheet, Text, View, Image } from 'react-native';

export default function App() {
  const placeholderImage = require('./assets/images/background-image.png');
  const [isHovered, setHover] = useState(false);

  return (
    <View style={styles.container}>
      <Text style={{color: '#25f'}}>Open up App.js to start working on your app!</Text>
      <View style={styles.imageContainer}>
        <Image source={placeholderImage} style={isHovered ? styles.imageHover : styles.image}>
        </Image>
      </View>
      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#ffe4c4',
    alignItems: 'center',
    justifyContent: 'center',
    paddingTop: 58,
  },
  imageContainer: {
    flex: 1,
  },
  image: {
    width: 320,
    height: 440,
    borderRadius: 100,
  },
  imageHover:{
    width: 320,
    height: 440,
    borderRadius: 8,
  }
});


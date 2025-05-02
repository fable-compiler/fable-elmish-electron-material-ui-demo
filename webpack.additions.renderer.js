var path = require("path");
var HtmlWebpackPlugin = require('html-webpack-plugin');

function resolve(filePath) {
  return path.join(__dirname, filePath)
}

module.exports = {
  entry: [resolve("src/Renderer/Renderer.fsproj"), resolve("src/Renderer/scss/main.scss"), resolve('static/index.html')],
  output: {
    filename: "renderer.js"
  },
  plugins: [
    new HtmlWebpackPlugin({
        template: path.resolve(__dirname, 'static/index.html')
    })
  ],
  module: {
    rules: [
      {
        test: /\.fs(x|proj)?$/,
        use: {
          loader: "fable-loader"
        }
      }
    ]
  }
}

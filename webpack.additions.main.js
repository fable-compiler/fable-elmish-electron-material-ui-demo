var path = require("path");

function resolve(filePath) {
  return path.join(__dirname, filePath)
}

module.exports = {
  entry: resolve("src/Main/Main.fsproj"),
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

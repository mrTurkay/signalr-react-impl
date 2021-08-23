import {
  HubConnection,
  HubConnectionBuilder,
  LogLevel,
} from "@microsoft/signalr";
import { useEffect, useState } from "react";

function App() {
  /** @type {HubConnection} */
  const [connection, setConnection] = useState(null);
  const [inputText, setInputText] = useState("");

  useEffect(() => {
    const connect = new HubConnectionBuilder()
      .withUrl("https://localhost:5001/hubs/chart")
      .withAutomaticReconnect()
      .configureLogging(LogLevel.Information)
      .build();

    setConnection(connect);
  }, []);

  console.log(connection);

  useEffect(() => {
    if (connection) {
      connection
        .start()
        .then(() => {
          console.log("then", connection);
          connection.on("TransferChartData", (message) => {
            console.log("connection on");
            console.log(message);
          });
        })
        .catch((error) => console.error(error));
    }
  }, [connection]);

  return (
    <div className="App">
      <h2>Murat</h2>
    </div>
  );
}

export default App;

import React, { Fragment, useState, useEffect } from 'react';
import { Tweet } from "./Components/tweet"
import { TweetComposer } from "./Components/tweetComposer"
import './custom.css'
import { Container } from 'reactstrap';
import axios from 'axios'

export interface ITweet {
    id: number;
    body: string;
    user: IUser;
}

export interface IUser {
    userId: number;
    firstName: string;
    lastName: string;
    username: string;
}

const App = () => {
    const [data, setData] = useState<ITweet[]>([]);

    useEffect(() => {
        if (data.length === 0) {
            fetch("https://localhost:44333/api/tweets")
                .then((response) => {
                    if (response.ok) {
                        return response.json();
                    }
                }).then((data: ITweet[]) => {
                    setData(data)
                });
        }
    });

    const createTweet = () => {
        axios.post("https://localhost:44333/api/tweets")
            .then((response) => {
                console.log(response);
            })
    };

    return (    
        <Fragment>
            <Container>
                <h1><a href="/">TwitterClone</a></h1>
                <TweetComposer createTweet={createTweet}></TweetComposer>
                {data.map((tweet: ITweet) => (
                    <Tweet tweet={tweet}></Tweet>
                ))}
            </Container>
        </Fragment>
    );
}



export default App;
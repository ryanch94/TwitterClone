import React, { Component, Fragment, useState, useEffect } from 'react';

import './custom.css'
import { Card, CardBody, Container, CardSubtitle } from 'reactstrap';

interface ITweet {
    id: number;
    body: string;
    user: IUser;
}

interface IUser {
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

    return (    
        <Fragment>
            <Container>
                <h1><a href="/">TwitterClone</a></h1>
                {data.map((tweet: ITweet) => (
                    <Card>
                        <CardBody>
                            <a href=".">
                                <h3>{tweet.user.firstName} {tweet.user.lastName}</h3>
                                <CardSubtitle>@{tweet.user.username}</CardSubtitle>
                            </a>
                            <p>{tweet.body}</p>
                            
                        </CardBody>
                    </Card>
                ))}
            </Container>
        </Fragment>
    );
}

function userLikesTweet(tweetId: number, userId: number) {
    if (tweetId === 0 || userId === 0) return false;
    fetch("https://localhost:44333/api/likes?tweetId=" + tweetId + "&userId" + userId)
        .then((resp) => {
            if (resp.ok) {
                return resp.json();
            }
        })
    return true;
}

export default App;
import React, { useEffect, useState } from 'react'
import { Card, CardBody, CardSubtitle } from "reactstrap";
import { ITweet } from "../App"

interface IProps {
    tweet: ITweet
}

export const Tweet: React.FC<IProps> = ({ tweet }) => {
    const [isLiked, setIsLiked] = useState<string>("false")

    useEffect(() => {
        if (tweet.id === 0 || tweet.user.userId === 0) {
            return;
        }
        var result: String = "";
        fetch("https://localhost:44333/api/likes?tweetId=" + tweet.id + "&userId=" + tweet.user.userId)
            .then((response) => {
                if (response.ok) {
                    response.text().then((text: string) => {
                        //result = text;
                        setIsLiked(text);
                    });
                }
            });
    });

    return (
        <Card key={tweet.id}>
            <CardBody>
                <a href=".">
                    <h3>{tweet.user.firstName} {tweet.user.lastName}</h3>
                    <CardSubtitle>@{tweet.user.username}</CardSubtitle>
                </a>
                <p>{tweet.body}</p>
                <p>{isLiked}</p>
            </CardBody>
        </Card>
    );
}